// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAltimeterReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (AltimeterReading))]
  [Guid(4226346867, 32606, 18632, 170, 26, 241, 243, 190, 252, 17, 68)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAltimeterReading
  {
    DateTime Timestamp { get; }

    double AltitudeChangeInMeters { get; }
  }
}
