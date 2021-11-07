// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaTimelineController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides information about and control over the rate, position, and state of a MediaPlayer. This class makes it possible to control and synchronize multiple media players from a single controller and makes it easier to create custom transport controls.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaTimelineController : IMediaTimelineController, IMediaTimelineController2
  {
    /// <summary>Initializes a new instance of the MediaTimelineController class.</summary>
    [MethodImpl]
    public extern MediaTimelineController();

    /// <summary>Starts the playback of the MediaTimelineController from the position 0.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Resumes the playback of the MediaTimelineController from the position at which the controller was paused.</summary>
    [MethodImpl]
    public extern void Resume();

    /// <summary>Pauses playback of the MediaTimelineController.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Gets or sets the current position of the MediaTimelineController.</summary>
    /// <returns>The current position of the MediaTimelineController.</returns>
    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the speed at which the position of the MediaTimelineController changes, expressed as a ratio to normal playback speed. For example, setting a value of 1.0 will result in normal playback speed, a value of 4.0 will result in a playback speed 4 times the normal speed.</summary>
    /// <returns>The speed at which the position of the MediaTimelineController changes.</returns>
    public extern double ClockRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating the current state of the MediaTimelineController, which can be either running or paused.</summary>
    /// <returns>A value indicating the current state of the MediaTimelineController</returns>
    public extern MediaTimelineControllerState State { [MethodImpl] get; }

    /// <summary>Occurs when the position of the MediaTimelineController changes.</summary>
    public extern event TypedEventHandler<MediaTimelineController, object> PositionChanged;

    /// <summary>Occurs when the state of the MediaTimelineController changes.</summary>
    public extern event TypedEventHandler<MediaTimelineController, object> StateChanged;

    /// <summary>Gets a value indicating the duration of the timeline. After the specified time span has elapsed, the timeline clock will no longer progress.</summary>
    /// <returns>A value indicating the duration of the timeline.</returns>
    public extern IReference<TimeSpan> Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating whether the timeline will loop, restarting the clock at zero, when it reaches the end of the time window specified by the Duration.</summary>
    /// <returns>True if looping is enabled; otherwise, false.</returns>
    public extern bool IsLoopingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the timeline controller encounters an internal error and can't continue playback.</summary>
    public extern event TypedEventHandler<MediaTimelineController, MediaTimelineControllerFailedEventArgs> Failed;

    /// <summary>Occurs when the timeline controller reaches the end of the time window specified by the Duration if IsLoopingEnabled is set to false.</summary>
    public extern event TypedEventHandler<MediaTimelineController, object> Ended;
  }
}
