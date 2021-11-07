// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSession3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackSession))]
  [Guid(2074260506, 41954, 16479, 183, 123, 164, 129, 44, 35, 139, 102)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IMediaPlaybackSession3
  {
    MediaRotation PlaybackRotation { get; set; }

    MediaPlaybackSessionOutputDegradationPolicyState GetOutputDegradationPolicyState();
  }
}
