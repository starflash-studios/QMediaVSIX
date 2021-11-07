// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3008016939, 53659, 18175, 159, 56, 222, 199, 117, 75, 185, 231)]
  [ExclusiveTo(typeof (ManipulationCompletedEventArgs))]
  internal interface IManipulationCompletedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    ManipulationDelta Cumulative { get; }

    ManipulationVelocities Velocities { get; }
  }
}
