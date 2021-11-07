// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2025203534, 26134, 17920, 160, 57, 146, 42, 93, 9, 51, 11)]
  [ExclusiveTo(typeof (Pivot))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IPivotStatics3
  {
    DependencyProperty HeaderFocusVisualPlacementProperty { get; }

    DependencyProperty IsHeaderItemsCarouselEnabledProperty { get; }
  }
}
