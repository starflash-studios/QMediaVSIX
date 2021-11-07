// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationInertiaStartingRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [Guid(610963881, 51779, 19467, 172, 239, 129, 232, 184, 20, 117, 32)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ManipulationInertiaStartingRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IManipulationInertiaStartingRoutedEventArgs
  {
    UIElement Container { get; }

    InertiaExpansionBehavior ExpansionBehavior { get; set; }

    InertiaRotationBehavior RotationBehavior { get; set; }

    InertiaTranslationBehavior TranslationBehavior { get; set; }

    bool Handled { get; set; }

    PointerDeviceType PointerDeviceType { get; }

    ManipulationDelta Delta { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }
  }
}
