// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElement3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1201630995, 4059, 20184, 146, 138, 77, 57, 22, 156, 60, 210)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MediaElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaElement3
  {
    MediaTransportControls TransportControls { get; set; }

    event TypedEventHandler<MediaElement, PartialMediaFailureDetectedEventArgs> PartialMediaFailureDetected;

    void SetPlaybackSource(IMediaPlaybackSource source);

    CastingSource GetAsCastingSource();
  }
}
