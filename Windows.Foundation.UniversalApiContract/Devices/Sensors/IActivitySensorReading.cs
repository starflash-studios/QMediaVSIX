// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2232572566, 5234, 16546, 178, 174, 225, 239, 41, 34, 108, 120)]
  [ExclusiveTo(typeof (ActivitySensorReading))]
  internal interface IActivitySensorReading
  {
    DateTime Timestamp { get; }

    ActivityType Activity { get; }

    ActivitySensorReadingConfidence Confidence { get; }
  }
}
