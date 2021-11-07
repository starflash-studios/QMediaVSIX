// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [WebHostHidden]
  [Guid(1362684248, 13149, 16912, 139, 187, 10, 162, 180, 181, 194, 158)]
  internal interface IContentPresenter2
  {
    OpticalMarginAlignment OpticalMarginAlignment { get; set; }

    TextLineBounds TextLineBounds { get; set; }
  }
}
