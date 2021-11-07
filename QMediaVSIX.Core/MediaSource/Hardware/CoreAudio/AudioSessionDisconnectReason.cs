namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <inheritdoc cref="AudioUtilities"/>
public enum AudioSessionDisconnectReason {
	DisconnectReasonDeviceRemoval = 0,
	DisconnectReasonServerShutdown = 1,
	DisconnectReasonFormatChanged = 2,
	DisconnectReasonSessionLogoff = 3,
	DisconnectReasonSessionDisconnected = 4,
	DisconnectReasonExclusiveModeOverride = 5
}