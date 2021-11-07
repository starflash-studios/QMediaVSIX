// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerRateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlayerRateChangedEventArgs))]
  [Guid(1080036696, 15201, 19378, 152, 159, 252, 101, 96, 139, 108, 171)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayerRateChangedEventArgs
  {
    double NewRate { get; }
  }
}
