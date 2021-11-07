// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(691010196, 6981, 16444, 186, 6, 177, 6, 219, 166, 154, 100)]
  [ExclusiveTo(typeof (Compass))]
  internal interface ICompass
  {
    CompassReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Compass, CompassReadingChangedEventArgs> ReadingChanged;
  }
}
