// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IManipulationStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (ManipulationStartedEventArgs))]
  [Guid(3723265854, 53198, 18738, 140, 29, 60, 61, 1, 26, 52, 192)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IManipulationStartedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    ManipulationDelta Cumulative { get; }
  }
}
