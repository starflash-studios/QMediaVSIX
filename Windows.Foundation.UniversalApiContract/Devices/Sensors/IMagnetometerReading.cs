// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (MagnetometerReading))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(204260365, 60413, 20060, 187, 17, 175, 194, 155, 60, 174, 97)]
  internal interface IMagnetometerReading
  {
    DateTime Timestamp { get; }

    float MagneticFieldX { get; }

    float MagneticFieldY { get; }

    float MagneticFieldZ { get; }

    MagnetometerAccuracy DirectionalAccuracy { get; }
  }
}
