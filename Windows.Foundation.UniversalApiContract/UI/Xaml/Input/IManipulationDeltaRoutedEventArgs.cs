// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationDeltaRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (ManipulationDeltaRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1074616212, 19567, 18717, 130, 214, 53, 23, 16, 147, 153, 198)]
  internal interface IManipulationDeltaRoutedEventArgs
  {
    UIElement Container { get; }

    Point Position { get; }

    bool IsInertial { get; }

    ManipulationDelta Delta { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }

    void Complete();
  }
}
