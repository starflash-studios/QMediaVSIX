// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Audio;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(1562231928, 17664, 17713, 179, 244, 119, 122, 113, 73, 31, 127)]
  internal interface IMediaPlayer7
  {
    AudioStateMonitor AudioStateMonitor { get; }
  }
}
