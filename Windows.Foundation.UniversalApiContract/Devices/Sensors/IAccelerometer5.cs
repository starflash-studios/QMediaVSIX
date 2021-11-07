// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometer5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Accelerometer))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(2122215457, 57076, 21414, 175, 67, 128, 111, 213, 56, 237, 246)]
  internal interface IAccelerometer5
  {
    AccelerometerDataThreshold ReportThreshold { get; }
  }
}
