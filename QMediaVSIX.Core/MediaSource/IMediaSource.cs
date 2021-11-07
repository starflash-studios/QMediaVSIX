namespace QMediaVSIX.Core.MediaSource;

public interface IMediaSource {
	ICapability PlayCapability { get; }
	ICapability PauseCapability { get; }
	ICapability StopCapability { get; }
	ICapability SkipPreviousCapability { get; }
	ICapability SkipNextCapability { get; }
}