// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IBackgroundMediaPlayerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2238569409, 22007, 18207, 160, 242, 104, 172, 76, 144, 69, 146)]
  [ExclusiveTo(typeof (BackgroundMediaPlayer))]
  [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IBackgroundMediaPlayerStatics
  {
    MediaPlayer Current { [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromBackground;

    event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromForeground;

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void SendMessageToBackground(ValueSet value);

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void SendMessageToForeground(ValueSet value);

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    bool IsMediaPlaying();

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Shutdown();
  }
}
