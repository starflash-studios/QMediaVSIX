using QMediaVSIX.Core.Collections;

namespace QMediaVSIX.Core.MediaSource.Software;

public static class MediaSessionManager {
	public static WMCSessionManager SM { get; private set; }

	#region Events

	#region AcquiredSessionManager Event

	/// <summary>
	/// Event arguments for the <see cref="AcquiredSessionManager"/> event (<inheritdoc cref="AcquiredSessionManager"/>).
	/// </summary>
	/// <param name="E">The raised event arguments.</param>
	public delegate void AcquiredSessionManagerEventArgs( WMCSessionManager E );

	/// <summary>
	/// Invoked when a new <see cref="WMCSessionManager"/> is asynchronously retrieved.
	/// </summary>
	public static event AcquiredSessionManagerEventArgs AcquiredSessionManager = delegate { };

	/// <summary>
	/// Raises the <see cref="AcquiredSessionManager"/> event (<inheritdoc cref="AcquiredSessionManager"/>)
	/// </summary>
	/// <param name="E">The raised event arguments.</param>
	public static void OnAcquiredSessionManager( WMCSessionManager E ) => AcquiredSessionManager(E);

	#endregion

	#region SessionConnected Event

	/// <summary>
	/// Event arguments for the <see cref="SessionConnected"/> event (<inheritdoc cref="SessionConnected"/>).
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public delegate void SessionConnectedEventArgs( MediaSession Sender, Guid E );

	/// <summary>
	/// Invoked when a new media session is started.
	/// </summary>
	public static event SessionConnectedEventArgs SessionConnected = delegate { };

	/// <summary>
	/// Raises the <see cref="SessionConnected"/> event (<inheritdoc cref="SessionConnected"/>)
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public static void OnSessionConnected( MediaSession Sender, Guid E ) => SessionConnected(Sender, E);

	#endregion

	#region SessionDisconnected Event

	/// <summary>
	/// Event arguments for the <see cref="SessionDisconnected"/> event (<inheritdoc cref="SessionDisconnected"/>).
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	public delegate void SessionDisconnectedEventArgs( MediaSession Sender );

	/// <summary>
	/// Invoked when a session disconnects.
	/// </summary>
	public static event SessionDisconnectedEventArgs SessionDisconnected = delegate { };

	/// <summary>
	/// Raises the <see cref="SessionDisconnected"/> event (<inheritdoc cref="SessionDisconnected"/>)
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	public static void OnSessionDisconnected( MediaSession Sender ) => SessionDisconnected(Sender);

	#endregion

	#endregion

	static MediaSessionManager() {
		SM = null!;
		static void KeyAdded( ObservableDictionary<Guid, MediaSession> Dict, Guid Key ) => OnSessionConnected(Dict[Key], Key);
		Sessions.KeyAdded += KeyAdded;
		InitAsync();
	}

	static async void InitAsync() {
		Debug.WriteLine("Retrieving manager...");
		SM = await RequestSessionManagerAsync();
		Debug.WriteLine("Manager found.");
		SM.SessionsChanged += SM_SessionsChanged;
		Debug.WriteLine("Refreshing sessions...");
		RefreshSessions();
		Debug.WriteLine("Sessions refreshed.");
		OnAcquiredSessionManager(SM);
	}


	public static Task<WMCSessionManager> RequestSessionManagerAsync() => WMCSessionManager.RequestAsync().AsTask();

	/// <summary>
	/// Checks all current sessions in the <see cref="WMCSessionManager"/>, and updates the list of <see cref="Sessions"/> accordingly - removing old sessions, and adding new sessions.
	/// </summary>
	public static void RefreshSessions() {
		Debug.WriteLine("Staleness Check--");
		List<Guid> Known = Sessions.Keys.ToList();
		foreach ( WMCSession Sess in SM.GetSessions() ) { //Check all possible sessions
			Guid Identifier = MediaSession.GetIdentifier(Sess);
			if ( Known.Contains(Identifier) ) { //Ignore already known sessions
				Debug.WriteLine($"\tPreExisting: {Identifier} ({Sess.SourceAppUserModelId})");
				Known.Remove(Identifier);
				continue;
			}
			Debug.WriteLine($"\tNew: {Identifier} ({Sess.SourceAppUserModelId})");
			MediaSession NewSess = new MediaSession(Sess); //Add new sessions
			Sessions.Add(Identifier, NewSess);
		}
		foreach( Guid Removed in Known ) { //Remove no longer existing sessions
			Debug.WriteLine($"\tRemoved: {Removed}");
			MediaSession RemovedSession = Sessions[Removed];
			Sessions.Remove(Removed);
			SessionDisconnected(RemovedSession);
		}
		Debug.WriteLine("-----------------");
	}

	public static readonly ObservableDictionary<Guid, MediaSession> Sessions = new ObservableDictionary<Guid, MediaSession>();

	static void SM_SessionsChanged( WMCSessionManager Sender, WMCSessionsChangedEventArgs Args ) {
		Debug.WriteLine($"SessionsChanged on {Sender} (args: {Args})");
		RefreshSessions();
	}
}