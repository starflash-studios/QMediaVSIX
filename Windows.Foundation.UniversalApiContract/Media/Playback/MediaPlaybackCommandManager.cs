// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackCommandManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the behavior of and receives events from the System Media Transport Controls. Use this class to customize the interaction between a MediaPlayer and the System Media Transport Controls.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlaybackCommandManager : IMediaPlaybackCommandManager
  {
    /// <summary>Gets or sets a value indicating whether the MediaPlaybackCommandManager is enabled.</summary>
    /// <returns>True if the MediaPlaybackCommandManager is enabled; otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MediaPlayer instance associated with the MediaPlaybackCommandManager.</summary>
    /// <returns>The MediaPlayer instance associated with the MediaPlaybackCommandManager.</returns>
    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Play** button in the System Media Transport Controls is tapped.</summary>
    /// <returns>An object that defines the behavior when the **Pause** button is tapped.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior PlayBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Pause** button in the System Media Transport Controls is tapped.</summary>
    /// <returns>An object that defines the behavior when the **Pause** button is tapped.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior PauseBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Next** button in the System Media Transport Controls is tapped.</summary>
    /// <returns>An object that defines the behavior when the **Next** button is tapped.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior NextBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Previous** button in the System Media Transport Controls is tapped.</summary>
    /// <returns>An object that defines the behavior when the **Previous** button is tapped.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior PreviousBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Fast-forward** button in the System Media Transport Controls is tapped.</summary>
    /// <returns>An object that defines the behavior when the **Fast-forward** button is tapped.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior FastForwardBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Rewind** button in the System Media Transport Controls is tapped.</summary>
    /// <returns>An object that defines the behavior when the **Rewind** button is tapped.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior RewindBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Shuffle** button in the System Media Transport Controls is toggled.</summary>
    /// <returns>An object that defines the behavior when the **Shuffle** button is toggled.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior ShuffleBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the **Auto-repeat** control in the System Media Transport Controls is toggled.</summary>
    /// <returns>An object that defines the behavior when the **Auto-repeat** control is toggled.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior AutoRepeatModeBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the playback position control in the System Media Transport Controls is moved.</summary>
    /// <returns>An object that defines the behavior when the playback position control is moved.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior PositionBehavior { [MethodImpl] get; }

    /// <summary>Gets an object that defines the behavior when the playback rate is changed using the System Media Transport Controls.</summary>
    /// <returns>An object that defines the behavior when the playback rate is changed.</returns>
    public extern MediaPlaybackCommandManagerCommandBehavior RateBehavior { [MethodImpl] get; }

    /// <summary>Occurs when the command manager receives a command from the **Play** control of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPlayReceivedEventArgs> PlayReceived;

    /// <summary>Occurs when the command manager receives a command from the **Pause** button of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPauseReceivedEventArgs> PauseReceived;

    /// <summary>Occurs when the command manager receives a command from the **Next** button of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerNextReceivedEventArgs> NextReceived;

    /// <summary>Occurs when the command manager receives a command from the **Previous** button of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPreviousReceivedEventArgs> PreviousReceived;

    /// <summary>Occurs when the command manager receives a command from the **Fast-forward** button of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerFastForwardReceivedEventArgs> FastForwardReceived;

    /// <summary>Occurs when the command manager receives a command from the **Rewind** button of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRewindReceivedEventArgs> RewindReceived;

    /// <summary>Occurs when the command manager receives a command from the **Shuffle** control of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerShuffleReceivedEventArgs> ShuffleReceived;

    /// <summary>Occurs when the command manager receives a command from the **Auto-repeat** control of the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs> AutoRepeatModeReceived;

    /// <summary>Occurs when the command manager receives a command changing the current playback position from the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPositionReceivedEventArgs> PositionReceived;

    /// <summary>Occurs when the command manager receives a command changing the current playback rate from the System Media Transport Controls.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRateReceivedEventArgs> RateReceived;
  }
}
