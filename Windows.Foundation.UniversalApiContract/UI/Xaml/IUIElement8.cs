// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(985075333, 54536, 17527, 182, 248, 14, 67, 87, 1, 200, 54)]
  [ExclusiveTo(typeof (UIElement))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IUIElement8
  {
    DependencyObject KeyTipTarget { get; set; }

    DependencyObject KeyboardAcceleratorPlacementTarget { get; set; }

    KeyboardAcceleratorPlacementMode KeyboardAcceleratorPlacementMode { get; set; }

    event TypedEventHandler<UIElement, BringIntoViewRequestedEventArgs> BringIntoViewRequested;
  }
}
