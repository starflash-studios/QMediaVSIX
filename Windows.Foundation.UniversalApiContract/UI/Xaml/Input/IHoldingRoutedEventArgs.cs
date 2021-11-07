// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IHoldingRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HoldingRoutedEventArgs))]
  [Guid(3259432739, 55309, 17630, 141, 185, 13, 129, 94, 38, 154, 192)]
  internal interface IHoldingRoutedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    HoldingState HoldingState { get; }

    bool Handled { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
