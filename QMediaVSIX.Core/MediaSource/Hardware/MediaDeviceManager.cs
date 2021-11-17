#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using CSCore.CoreAudioAPI;

using QMediaVSIX.Core.Collections;

#endregion

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

	public static NonRemovableList<DataFlow> AcceptedFlows = new NonRemovableList<DataFlow>(DataFlow.Render);
	public static NonRemovableList<Role> AcceptedRoles = new NonRemovableList<Role>(Role.Multimedia); //TODO: Implement these below & on flow/role add

	static MediaDeviceManager() {
		//Debug.WriteLine("Constructing device manager.");
		foreach ( DataFlow DF in AcceptedFlows ) {
			foreach ( Role Rl in AcceptedRoles ) {
				TryAddEndpoint(DF, Rl);
			}
		}

		AcceptedFlows.CollectionItemAdded += ( _, E ) => {
			foreach ( Role Rl in AcceptedRoles ) {
				TryAddEndpoint(E, Rl);
			}
		};

		AcceptedRoles.CollectionItemAdded += (_, E) => {
			foreach(DataFlow F in AcceptedFlows ) {
				TryAddEndpoint(F, E);
			}
		};
	}

	static readonly Dictionary<DataFlow, List<Role>> _AddedEndpoints = new Dictionary<DataFlow, List<Role>>();

	internal static void TryAddEndpoint( DataFlow F, Role R ) {
		if ( _AddedEndpoints.ContainsKey(F) ) {
			if ( _AddedEndpoints[F].Contains(R) ) {
				Debug.WriteLine($"Audio Endpoint {F}::{R} already added, ignoring.");
				return;
			}
			_AddedEndpoints[F].Add(R);
		} else {
			_AddedEndpoints.Add(F, new List<Role> { R });
		}
		AddEndpoint(F, R);
	}

	internal static void AddEndpoint(DataFlow F, Role R) {
		Debug.WriteLine($"Adding Audio Endpoint {F}::{R}...");
		using ( MMDeviceEnumerator Enumerator = new MMDeviceEnumerator() ) {
			//Debug.WriteLine("A");
			using ( MMDevice? Device = Enumerator.GetDefaultAudioEndpoint(F, R) ) {
				//Debug.WriteLine("B");
				using ( AudioSessionManager2 SessionManager = AudioSessionManager2.FromMMDevice(Device) ) {
					Debug.WriteLine($"\tAdding device {Device} >> {SessionManager}");
					//Debug.WriteLine("C");
					SessionManager.SessionCreated += (_, E) => {
						Add(E.NewSession, F, R);
					};
					//Debug.WriteLine("D");
					using ( AudioSessionEnumerator SessionEnumerator = SessionManager.GetSessionEnumerator() ) {
						//Debug.WriteLine("E");
						// ReSharper disable once LoopCanBePartlyConvertedToQuery
						foreach ( AudioSessionControl Control in SessionEnumerator ) {
							//Debug.WriteLine($"\t\tAdding control {Control.DisplayName} ({Control.IconPath})");
							//Debug.WriteLine("F");
							Debug.WriteLine($"\t\tFeck you {Control.DisplayName} -- {Control.IconPath}");
							Add(Control, F, R);
						}
					}
				}
			}
		}
	}

	internal static void Add( AudioSessionControl ASC, DataFlow Flow, Role Role ) {
		Debug.WriteLine($"Add called on {ASC}, {Flow}, {Role}");
		AudioSessionControl2 AS = ASC.QueryInterface<AudioSessionControl2>();
		Guid Identifier = MediaDevice.GetIdentifier(AS);
		if ( !Devices.ContainsKey(Identifier) ) {
			MediaDevice New = new MediaDevice(ASC, AS, Flow, Role);
			Devices.Add(Identifier, New);
			ASC.SessionDisconnected += ( _, _ ) => {
				Devices.Remove(Identifier);
				OnDeviceDisconnected(New);
			};
			Debug.WriteLine($"Adding control {Identifier} :: {New}");
			OnDeviceConnected(New, Identifier);
		} else {
			Debug.WriteLine($"Previously added control: {Identifier}");
		}
	}

}