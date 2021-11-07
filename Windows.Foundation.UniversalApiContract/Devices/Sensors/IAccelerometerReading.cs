// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3120462539, 54097, 16559, 139, 182, 122, 169, 174, 100, 31, 183)]
  [ExclusiveTo(typeof (AccelerometerReading))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAccelerometerReading
  {
    DateTime Timestamp { get; }

    double AccelerationX { get; }

    double AccelerationY { get; }

    double AccelerationZ { get; }
  }
}
