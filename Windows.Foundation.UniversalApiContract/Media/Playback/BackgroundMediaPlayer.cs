// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.BackgroundMediaPlayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides access to the media player while it is running in the background.</summary>
  /// <deprecated type="deprecate">Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBackgroundMediaPlayerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public static class BackgroundMediaPlayer
  {
    /// <summary>Gets the current instance of the background media player.</summary>
    /// <returns>The current instance of the background media player.</returns>
    public static extern MediaPlayer Current { [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when a message is received from the background task.</summary>
    public static extern event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromBackground;

    /// <summary>Occurs when a message is received from the foreground task.</summary>
    public static extern event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromForeground;

    /// <summary>Sends a message to the background media player.</summary>
    /// <deprecated type="deprecate">Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.</deprecated>
    /// <param name="value">Set of values representing the message.</param>
    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void SendMessageToBackground(ValueSet value);

    /// <summary>Sends a message to the foreground task.</summary>
    /// <deprecated type="deprecate">Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.</deprecated>
    /// <param name="value">Set of values representing the message.</param>
    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void SendMessageToForeground(ValueSet value);

    /// <summary>Returns a Boolean value indicating if other media is currently playing on the device.</summary>
    /// <deprecated type="deprecate">Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.</deprecated>
    /// <returns>Boolean value indicating if other media is currently playing on the device.</returns>
    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern bool IsMediaPlaying();

    /// <summary>Shuts down the current background media player.</summary>
    /// <deprecated type="deprecate">Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.</deprecated>
    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void Shutdown();
  }
}
