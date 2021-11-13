using System.Runtime.CompilerServices;

using QMediaVSIX.Core.Collections;
using QMediaVSIX.Core.MediaSource.Ecosystem;
using QMediaVSIX.Core.MediaSource.Hardware;
using QMediaVSIX.Core.MediaSource.Software;

namespace QMediaVSIX.Core.MediaSource; 

public static class MediaSourceManager {

	#region Events

	#region EcosystemConnected Event

	/// <summary>
	/// Event arguments for the <see cref="EcosystemConnected"/> event (<inheritdoc cref="EcosystemConnected"/>).
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public delegate void EcosystemAddedEventArgs( MediaEcosystem Sender, Guid E );

	/// <summary>
	/// Invoked when a MediaEcosystem is added.
	/// </summary>
	public static event EcosystemAddedEventArgs EcosystemConnected = delegate { };

	/// <summary>
	/// Raises the <see cref="EcosystemConnected"/> event (<inheritdoc cref="EcosystemConnected"/>)
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public static void OnEcosystemConnected( MediaEcosystem Sender, Guid E ) => EcosystemConnected(Sender, E);

	#endregion

	#region EcosystemDisconnected Event

	/// <summary>
	/// Event arguments for the <see cref="EcosystemDisconnected"/> event (<inheritdoc cref="EcosystemDisconnected"/>).
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public delegate void EcosystemDisconnectedEventArgs( MediaEcosystem Sender, Guid E );

	/// <summary>
	/// Invoked when a MediaEcosystem disconnects.
	/// </summary>
	public static event EcosystemDisconnectedEventArgs EcosystemDisconnected = delegate { };

	/// <summary>
	/// Raises the <see cref="EcosystemDisconnected"/> event (<inheritdoc cref="EcosystemDisconnected"/>)
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public static void OnEcosystemDisconnected( MediaEcosystem Sender, Guid E ) => EcosystemDisconnected(Sender, E);

	#endregion

	#endregion

	static MediaSourceManager() => Initialise();

	public static bool EnableEcosystems { get; set; } = true;

	public static void Initialise() {
		Debug.WriteLine("Constructing managers.");
		RuntimeHelpers.RunClassConstructor(typeof(MediaSessionManager).TypeHandle);
		RuntimeHelpers.RunClassConstructor(typeof(MediaDeviceManager).TypeHandle);

		MediaSessionManager.SessionConnected += MediaSessionConnectedManager_SessionConnected;
		MediaDeviceManager.DeviceConnected += MediaDeviceConnectedManager_DeviceConnected;

		MediaSessionManager.SessionDisconnected += MediaSessionDisconnectedManager_SessionDisconnected;
		MediaDeviceManager.DeviceDisconnected += MediaDeviceDisconnectedManager_DeviceDisconnected;

		GetInitialLinked();
	}

	static void MediaDeviceDisconnectedManager_DeviceDisconnected( MediaDevice Sender ) {
		if ( !EnableEcosystems ) { return; }
		foreach ( (Guid Identifier, MediaEcosystem Ecosystem) in Ecosystems ) {
			if ( Ecosystem.Device.Identifier == Sender.Identifier ) {
				RemoveEcosystem(Identifier, Ecosystem);
			}
		}
	}

	static void MediaSessionDisconnectedManager_SessionDisconnected( MediaSession Sender ) {
		if ( !EnableEcosystems ) { return; }
		List<(Guid Id, MediaEcosystem ME)> ToRemove = new List<(Guid, MediaEcosystem)>();
		lock ( Ecosystems ) {
			foreach ( (Guid Identifier, MediaEcosystem Ecosystem) in Ecosystems ) {
				if ( Ecosystem.Session.Identifier == Sender.Identifier ) {
					ToRemove.Add((Identifier, Ecosystem));
				}
			}
			foreach( (Guid Id, MediaEcosystem ME) in ToRemove ) {
				RemoveEcosystem(Id, ME);
			}
		}
	}

	static void MediaDeviceConnectedManager_DeviceConnected( MediaDevice Sender, Guid E ) {
		if ( !EnableEcosystems ) { return; }
		if ( Sender.FindSingleLinked(MediaSessionManager.Sessions.Values.ToArray()) is { } Pair ) {
			AddNewEcosystem(Pair);
		}
	}

	static void MediaSessionConnectedManager_SessionConnected( MediaSession Sender, Guid E ) {
		if ( !EnableEcosystems ) { return; }
		if (Sender.FindSingleLinked(MediaDeviceManager.Devices.Values.ToArray()) is { } Pair ) {
			AddNewEcosystem(Pair);
		}
	}

	internal static void GetInitialLinked() {
		if ( !EnableEcosystems ) { return; }
		MediaDeviceManager.Devices.FindLinked(MediaSessionManager.Sessions).ForAll(AddNewEcosystem);
	}

	internal static void AddNewEcosystem( (int ProcessId, MediaSession Session, MediaDevice Device) Pair ) => AddNewEcosystem(Pair.ProcessId, Pair.Session, Pair.Device);

	internal static void AddNewEcosystem( int ProcessId, MediaSession Session, MediaDevice Device ) {
		if ( !EnableEcosystems ) { return; }
		Guid Combined = MediaEcosystem.GetIdentifier(Session, Device);
		if ( !Ecosystems.ContainsKey(Combined) ) {
			Ecosystems.Add(Combined, new MediaEcosystem(ProcessId, Session, Device));
		}
	}

	internal static void RemoveEcosystem( Guid Identifier, MediaEcosystem Ecosystem ) {
		if ( !EnableEcosystems ) { return; }
		if ( Ecosystems.ContainsKey(Identifier) ) {
			Ecosystems.Remove(Identifier);
			EcosystemDisconnected(Ecosystem, Identifier);
		}
	}

	public static ObservableDictionary<Guid, MediaSession> Sessions => MediaSessionManager.Sessions;
	public static ObservableDictionary<Guid, MediaDevice> Devices => MediaDeviceManager.Devices;

	public static readonly ObservableDictionary<Guid, MediaEcosystem> Ecosystems = new ObservableDictionary<Guid, MediaEcosystem>();

}