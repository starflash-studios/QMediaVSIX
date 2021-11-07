// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPenDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Guid(34067239, 32696, 21862, 140, 52, 248, 52, 32, 55, 183, 249)]
  [ExclusiveTo(typeof (PenDevice))]
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  internal interface IPenDevice2
  {
    SimpleHapticsController SimpleHapticsController { get; }
  }
}
