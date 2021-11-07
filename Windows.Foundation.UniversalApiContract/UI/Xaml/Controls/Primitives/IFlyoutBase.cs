// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (FlyoutBase))]
  [Guid(1916725771, 53550, 17165, 169, 240, 155, 179, 43, 191, 153, 19)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFlyoutBase
  {
    FlyoutPlacementMode Placement { get; set; }

    event EventHandler<object> Opened;

    event EventHandler<object> Closed;

    event EventHandler<object> Opening;

    void ShowAt(FrameworkElement placementTarget);

    void Hide();
  }
}
