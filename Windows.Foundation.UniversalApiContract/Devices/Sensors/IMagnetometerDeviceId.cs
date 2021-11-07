// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerDeviceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1488230594, 32331, 16460, 159, 197, 93, 232, 180, 14, 186, 227)]
  [ExclusiveTo(typeof (Magnetometer))]
  internal interface IMagnetometerDeviceId
  {
    string DeviceId { get; }
  }
}
