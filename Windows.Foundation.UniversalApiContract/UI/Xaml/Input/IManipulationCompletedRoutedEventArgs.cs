// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationCompletedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (ManipulationCompletedRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3048053539, 12097, 18830, 131, 25, 1, 94, 232, 167, 83, 70)]
  [WebHostHidden]
  internal interface IManipulationCompletedRoutedEventArgs
  {
    UIElement Container { get; }

    Point Position { get; }

    bool IsInertial { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }
  }
}
