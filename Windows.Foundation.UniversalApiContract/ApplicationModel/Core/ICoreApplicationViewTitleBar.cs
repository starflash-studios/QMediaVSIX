// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationViewTitleBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplicationViewTitleBar))]
  [WebHostHidden]
  [Guid(7157219, 57841, 17179, 149, 8, 41, 185, 105, 38, 172, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreApplicationViewTitleBar
  {
    bool ExtendViewIntoTitleBar { set; get; }

    double SystemOverlayLeftInset { get; }

    double SystemOverlayRightInset { get; }

    double Height { get; }

    event TypedEventHandler<CoreApplicationViewTitleBar, object> LayoutMetricsChanged;

    bool IsVisible { get; }

    event TypedEventHandler<CoreApplicationViewTitleBar, object> IsVisibleChanged;
  }
}
