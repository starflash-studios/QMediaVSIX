#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel;
using System.Threading.Tasks;

using QMediaVSIX.Core.Collections;

#endregion

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

	#region CurrentSessionChanged Event

	/// <summary>
	/// Event arguments for the <see cref="CurrentSessionChanged"/> event (<inheritdoc cref="CurrentSessionChanged"/>).
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	/// <param name="O">The raised event arguments.</param>
	public delegate void CurrentSessionChangedEventArgs( Guid Sender, MediaSession? E, MediaSession? O );

	/// <summary>
	/// Invoked when the current session windows believes the user wishes to control changes.
	/// </summary>
	public static event CurrentSessionChangedEventArgs CurrentSessionChanged = delegate { };

	/// <summary>
	/// Raises the <see cref="CurrentSessionChanged"/> event (<inheritdoc cref="CurrentSessionChanged"/>)
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	/// <param name="O">The raised event arguments.</param>
	public static void OnCurrentSessionChanged( Guid Sender, MediaSession? E, MediaSession? O ) => CurrentSessionChanged(Sender, E, O);

	#endregion

	#endregion

	static MediaSession? _Current;
	public static MediaSession? Current {
		get => _Current;
		private set {
			if ( _Current == value ) { return; }
			MediaSession? Old = _Current;
			_Current = value;
			//Debug.WriteLine("SESSION CHANGED");
			OnCurrentSessionChanged(value?.Identifier ?? Guid.Empty, value, Old);
		}
	}

	public static void ForceSetCurrent( MediaSession? Session ) => Current = Session;

	static MediaSessionManager() {
		Debug.WriteLine("Constructing session manager.");
		SM = null!;
		static void KeyAdded( ObservableDictionary<Guid, MediaSession> Dict, Guid Key ) => OnSessionConnected(Dict[Key], Key);
		Sessions.KeyAdded += KeyAdded;
		static void KeyRemoved( ObservableDictionary<Guid, MediaSession> _, Guid __, MediaSession Session ) => OnSessionDisconnected(Session);
		Sessions.KeyAdded += KeyAdded;
		Sessions.KeyRemoved += KeyRemoved;
		InitAsync();
	}

	public static void OnNextPropertyChange( PropertyChangedEventHandler Handler ) {
		void OnPropChange(object Sender, PropertyChangedEventArgs E) {
			lock ( Sessions ) {
				foreach ( (_, MediaSession Session) in Sessions ) {
					Session.PropertyChanged -= Handler;
					Session.PropertyChanged -= OnPropChange;
				}
			}
		}
		lock ( Sessions ) {
			foreach ( (_, MediaSession Session) in Sessions ) {
				Session.PropertyChanged += OnPropChange;
				Session.PropertyChanged += Handler;
			}
		}
	}

	static async void InitAsync() {
		//Debug.WriteLine("Retrieving manager...");
		SM = await RequestSessionManagerAsync();
		//Debug.WriteLine("Manager found.");
		SM.SessionsChanged += SM_SessionsChanged;
		//Debug.WriteLine("Refreshing sessions...");
		RefreshSessions();
		//Debug.WriteLine("Sessions refreshed.");
		SM.CurrentSessionChanged += SM_CurrentSessionChanged;
		OnAcquiredSessionManager(SM);
	}

	static void SM_CurrentSessionChanged( WMCSessionManager Sender, WMCCurrentSessionChangedEventArgs Args ) => RefreshCurrentSession();

	public static void RefreshCurrentSession() {
		switch ( SM.GetCurrentSession() ) {
			case { } NewCurrent:
				Guid NewSessionIdentifier = MediaSession.GetIdentifier(NewCurrent);
				lock ( Sessions ) {
					foreach ( (Guid Identifier, MediaSession Session) in Sessions ) {
						if ( Identifier == NewSessionIdentifier ) {
							Debug.WriteLine($"Current session changed to {Session}.");
							Current = Session;
							//OnCurrentSessionChanged(Identifier, Session);
						}
					}
				}
				break;
			default:
				Current = null;
				break;
		}
	}

	public static Task<WMCSessionManager> RequestSessionManagerAsync() => WMCSessionManager.RequestAsync().AsTask();

	/// <summary>
	/// Checks all current sessions in the <see cref="WMCSessionManager"/>, and updates the list of <see cref="Sessions"/> accordingly - removing old sessions, and adding new sessions.
	/// </summary>
	public static void RefreshSessions() {
		lock ( Sessions ) {
			Debug.WriteLine("Staleness Check--");
			List<Guid>
				Known = Sessions.Keys.ToList(),
				New = new List<Guid>();
			foreach ( WMCSession Sess in SM.GetSessions() ) { //Check all possible sessions
				Guid Identifier = MediaSession.GetIdentifier(Sess);
				if ( Known.Contains(Identifier) ) { //Ignore already known sessions
					Debug.WriteLine($"\tPreExisting: {Identifier} ({Sess.SourceAppUserModelId})");
					Known.Remove(Identifier);
					continue;
				}
				if ( !New.Contains(Identifier) ) {
					Debug.WriteLine($"\tNew: {Identifier} ({Sess.SourceAppUserModelId}) -- {string.Join(",", New)}");
					MediaSession NewSess = new MediaSession(Sess); //Add new sessions
					Sessions.Add(Identifier, NewSess);
					New.Add(Identifier);
				} else {
					Debug.WriteLine($"\tDuplicate: {Identifier} ({Sess.SourceAppUserModelId})");
				}
			}
			foreach ( Guid Removed in Known ) { //Remove no longer existing sessions
				Debug.WriteLine($"\tRemoved: {Removed}");
				//MediaSession RemovedSession = Sessions[Removed];
				Sessions.Remove(Removed);
				//SessionDisconnected(RemovedSession);
			}
			Debug.WriteLine("-----------------");
			RefreshCurrentSession();
		}
	}

	public static readonly ObservableDictionary<Guid, MediaSession> Sessions = new ObservableDictionary<Guid, MediaSession>();

	static void SM_SessionsChanged( WMCSessionManager Sender, WMCSessionsChangedEventArgs Args ) {
		Debug.WriteLine($"SessionsChanged on {Sender} (args: {Args})");
		RefreshSessions();
	}
}