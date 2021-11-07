// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationInertiaStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(3711412376, 9919, 18042, 156, 229, 204, 243, 251, 17, 55, 30)]
  [ExclusiveTo(typeof (ManipulationInertiaStartingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IManipulationInertiaStartingEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    ManipulationDelta Delta { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }
  }
}
