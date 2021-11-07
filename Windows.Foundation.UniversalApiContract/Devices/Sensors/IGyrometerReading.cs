// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (GyrometerReading))]
  [Guid(3017203292, 7908, 17775, 157, 231, 226, 73, 59, 92, 142, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGyrometerReading
  {
    DateTime Timestamp { get; }

    double AngularVelocityX { get; }

    double AngularVelocityY { get; }

    double AngularVelocityZ { get; }
  }
}
