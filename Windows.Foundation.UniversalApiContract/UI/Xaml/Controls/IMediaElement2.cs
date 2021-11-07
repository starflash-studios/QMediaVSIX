// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElement2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4250131045, 45446, 18004, 191, 219, 24, 14, 210, 108, 173, 7)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaElement))]
  [WebHostHidden]
  internal interface IMediaElement2
  {
    bool AreTransportControlsEnabled { get; set; }

    Stretch Stretch { get; set; }

    bool IsFullWindow { get; set; }

    void SetMediaStreamSource(IMediaSource source);

    Uri PlayToPreferredSourceUri { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
