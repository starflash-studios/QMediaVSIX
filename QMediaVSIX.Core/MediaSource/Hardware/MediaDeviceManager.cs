using CSCore.CoreAudioAPI;

using QMediaVSIX.Core.Collections;

namespace QMediaVSIX.Core.MediaSource.Hardware;

public static class MediaDeviceManager {

	#region Events

	#region DeviceConnected Event

	/// <summary>
	/// Event arguments for the <see cref="DeviceConnected"/> event (<inheritdoc cref="DeviceConnected"/>).
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public delegate void DeviceConnectedEventArgs( MediaDevice Sender, Guid E );

	/// <summary>
	/// Invoked when a new media device is created.
	/// </summary>
	public static event DeviceConnectedEventArgs DeviceConnected = delegate { };

	/// <summary>
	/// Raises the <see cref="DeviceConnected"/> event (<inheritdoc cref="DeviceConnected"/>)
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	/// <param name="E">The raised event arguments.</param>
	public static void OnDeviceConnected( MediaDevice Sender, Guid E ) => DeviceConnected(Sender, E);

	#endregion

	#region DeviceDisconnected Event

	/// <summary>
	/// Event arguments for the <see cref="DeviceDisconnected"/> event (<inheritdoc cref="DeviceDisconnected"/>).
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	public delegate void DeviceDisconnectedEventArgs( MediaDevice Sender );

	/// <summary>
	/// Invoked when a media device disconnects.
	/// </summary>
	public static event DeviceDisconnectedEventArgs DeviceDisconnected = delegate { };

	/// <summary>
	/// Raises the <see cref="DeviceDisconnected"/> event (<inheritdoc cref="DeviceDisconnected"/>)
	/// </summary>
	/// <param name="Sender">The event raiser.</param>
	public static void OnDeviceDisconnected( MediaDevice Sender ) => DeviceDisconnected(Sender);

	#endregion

	#endregion

	public static readonly ObservableDictionary<Guid, MediaDevice> Devices = new ObservableDictionary<Guid, MediaDevice>();

	static MediaDeviceManager() {
		Debug.WriteLine("Constructing device manager.");
		using ( MMDeviceEnumerator Enumerator = new MMDeviceEnumerator() ) {
			Debug.WriteLine("A");
			using ( MMDevice? Device = Enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia) ) {
				Debug.WriteLine("B");
				using ( AudioSessionManager2 SessionManager = AudioSessionManager2.FromMMDevice(Device) ) {
					Debug.WriteLine("C");
					SessionManager.SessionCreated += SessionManager_SessionCreated;
					Debug.WriteLine("D");
					using ( AudioSessionEnumerator SessionEnumerator = SessionManager.GetSessionEnumerator() ) {
						Debug.WriteLine("E");
						// ReSharper disable once LoopCanBePartlyConvertedToQuery
						foreach ( AudioSessionControl Control in SessionEnumerator ) {
							Debug.WriteLine("F");
							Add(Control);
						}
					}
				}
			}
		}
	}

	internal static void Add( AudioSessionControl ASC ) {
		AudioSessionControl2 AS = ASC.QueryInterface<AudioSessionControl2>();
		Guid Identifier = MediaDevice.GetIdentifier(AS);
		if ( !Devices.ContainsKey(Identifier) ) {
			MediaDevice New = new MediaDevice(ASC, AS);
			Devices.Add(Identifier, New);
			ASC.SessionDisconnected += (_, _) => {
				Devices.Remove(Identifier);
				OnDeviceDisconnected(New);
			};
			OnDeviceConnected(New, Identifier);
		}
	}

	static void SessionManager_SessionCreated( object? Sender, SessionCreatedEventArgs E ) => Add(E.NewSession);

}