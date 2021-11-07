// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItem3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(221413920, 47114, 19721, 159, 248, 248, 112, 148, 161, 200, 49)]
  internal interface IMediaPlaybackItem3 : 
    IMediaPlaybackItem2,
    IMediaPlaybackItem,
    IMediaPlaybackSource
  {
    bool IsDisabledInPlaybackList { get; set; }

    double TotalDownloadProgress { get; }

    AutoLoadedDisplayPropertyKind AutoLoadedDisplayProperties { get; set; }
  }
}
