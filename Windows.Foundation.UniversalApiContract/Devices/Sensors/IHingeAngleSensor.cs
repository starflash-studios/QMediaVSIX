// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IHingeAngleSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3922968066, 49119, 17279, 140, 41, 136, 199, 115, 147, 211, 9)]
  [ExclusiveTo(typeof (HingeAngleSensor))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IHingeAngleSensor
  {
    [RemoteAsync]
    IAsyncOperation<HingeAngleReading> GetCurrentReadingAsync();

    string DeviceId { get; }

    double MinReportThresholdInDegrees { get; }

    double ReportThresholdInDegrees { get; set; }

    event TypedEventHandler<HingeAngleSensor, HingeAngleSensorReadingChangedEventArgs> ReadingChanged;
  }
}
