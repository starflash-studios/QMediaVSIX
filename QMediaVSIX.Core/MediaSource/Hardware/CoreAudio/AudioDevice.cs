namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <inheritdoc cref="AudioUtilities"/>
public sealed class AudioDevice {
	internal AudioDevice( string ID, AudioDeviceState State, IDictionary<string, object?> Properties ) {
		Id = ID;
		this.State = State;
		this.Properties = Properties;
	}

	public string Id { get;  }
	public AudioDeviceState State { get;  }
	public IDictionary<string, object?> Properties { get;  }

	public string Description {
		get {
			const string Pkey_Device_DeviceDesc = "{a45c254e-df1c-4efd-8020-67d146a850e0} 2";
			Properties.TryGetValue(Pkey_Device_DeviceDesc, out object? Value);
			return $"{Value}";
		}
	}

	public string ContainerId {
		get {
			const string Pkey_Devices_ContainerId = "{8c7ed206-3f8a-4827-b3ab-ae9e1faefc6c} 2";
			Properties.TryGetValue(Pkey_Devices_ContainerId, out object? Value);
			return $"{Value}";
		}
	}

	public string EnumeratorName {
		get {
			const string Pkey_Device_EnumeratorName = "{a45c254e-df1c-4efd-8020-67d146a850e0} 24";
			Properties.TryGetValue(Pkey_Device_EnumeratorName, out object? Value);
			return $"{Value}";
		}
	}

	public string InterfaceFriendlyName {
		get {
			const string Devpkey_DeviceInterface_FriendlyName = "{026e516e-b814-414b-83cd-856d6fef4822} 2";
			Properties.TryGetValue(Devpkey_DeviceInterface_FriendlyName, out object? Value);
			return $"{Value}";
		}
	}

	public string FriendlyName {
		get {
			const string Devpkey_Device_FriendlyName = "{a45c254e-df1c-4efd-8020-67d146a850e0} 14";
			Properties.TryGetValue(Devpkey_Device_FriendlyName, out object? Value);
			return $"{Value}";
		}
	}

	public string IconPath {
		get {
			const string Devpkey_DeviceClass_IconPath = "{259abffc-50a7-47ce-af08-68c9a7d73366} 12";
			Properties.TryGetValue(Devpkey_DeviceClass_IconPath, out object? Value);
			return $"{Value}";
		}
	}

	public override string ToString() => FriendlyName;
}