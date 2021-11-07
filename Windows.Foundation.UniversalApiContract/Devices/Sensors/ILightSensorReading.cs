// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LightSensorReading))]
  [Guid(4292829952, 8828, 19755, 179, 2, 252, 1, 66, 72, 92, 104)]
  internal interface ILightSensorReading
  {
    DateTime Timestamp { get; }

    float IlluminanceInLux { get; }
  }
}
