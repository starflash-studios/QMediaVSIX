// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaTransportControls))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(263291204, 40739, 4583, 171, 196, 206, 194, 120, 182, 181, 10)]
  [WebHostHidden]
  internal interface IMediaTransportControlsStatics4
  {
    DependencyProperty IsCompactOverlayButtonVisibleProperty { get; }

    DependencyProperty IsCompactOverlayEnabledProperty { get; }
  }
}
