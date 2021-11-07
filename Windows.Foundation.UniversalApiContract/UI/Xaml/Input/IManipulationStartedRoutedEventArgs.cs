// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1571924485, 40832, 18614, 174, 108, 79, 17, 157, 232, 255, 19)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ManipulationStartedRoutedEventArgs))]
  internal interface IManipulationStartedRoutedEventArgs
  {
    UIElement Container { get; }

    Point Position { get; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }

    ManipulationDelta Cumulative { get; }

    void Complete();
  }
}
