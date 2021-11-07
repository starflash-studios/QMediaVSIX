// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElementStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2666002470, 61780, 19910, 128, 20, 166, 235, 169, 135, 248, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaElement))]
  internal interface IMediaElementStatics2
  {
    DependencyProperty AreTransportControlsEnabledProperty { get; }

    DependencyProperty StretchProperty { get; }

    DependencyProperty IsFullWindowProperty { get; }

    DependencyProperty PlayToPreferredSourceUriProperty { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
