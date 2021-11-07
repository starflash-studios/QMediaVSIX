// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivot3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2512174998, 61658, 16521, 140, 101, 232, 184, 19, 84, 199, 102)]
  [ExclusiveTo(typeof (Pivot))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPivot3
  {
    PivotHeaderFocusVisualPlacement HeaderFocusVisualPlacement { get; set; }

    bool IsHeaderItemsCarouselEnabled { get; set; }
  }
}
