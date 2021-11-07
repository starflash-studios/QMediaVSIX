// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBase2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4163584862, 26035, 16838, 169, 226, 119, 182, 123, 196, 192, 12)]
  [ExclusiveTo(typeof (FlyoutBase))]
  [WebHostHidden]
  internal interface IFlyoutBase2
  {
    FrameworkElement Target { get; }

    bool AllowFocusOnInteraction { get; set; }

    LightDismissOverlayMode LightDismissOverlayMode { get; set; }

    bool AllowFocusWhenDisabled { get; set; }

    ElementSoundMode ElementSoundMode { get; set; }

    event TypedEventHandler<FlyoutBase, FlyoutBaseClosingEventArgs> Closing;
  }
}
