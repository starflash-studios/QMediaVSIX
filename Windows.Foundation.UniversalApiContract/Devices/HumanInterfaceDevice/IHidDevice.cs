// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [Guid(1602884839, 8704, 17198, 149, 218, 208, 155, 135, 213, 116, 168)]
  [ExclusiveTo(typeof (HidDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidDevice : IClosable
  {
    ushort VendorId { get; }

    ushort ProductId { get; }

    ushort Version { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    [RemoteAsync]
    [Overload("GetInputReportAsync")]
    IAsyncOperation<HidInputReport> GetInputReportAsync();

    [RemoteAsync]
    [Overload("GetInputReportByIdAsync")]
    IAsyncOperation<HidInputReport> GetInputReportAsync(ushort reportId);

    [Overload("GetFeatureReportAsync")]
    [RemoteAsync]
    IAsyncOperation<HidFeatureReport> GetFeatureReportAsync();

    [RemoteAsync]
    [Overload("GetFeatureReportByIdAsync")]
    IAsyncOperation<HidFeatureReport> GetFeatureReportAsync(
      ushort reportId);

    [Overload("CreateOutputReport")]
    HidOutputReport CreateOutputReport();

    [Overload("CreateOutputReportById")]
    HidOutputReport CreateOutputReport(ushort reportId);

    [Overload("CreateFeatureReport")]
    HidFeatureReport CreateFeatureReport();

    [Overload("CreateFeatureReportById")]
    HidFeatureReport CreateFeatureReport(ushort reportId);

    IAsyncOperation<uint> SendOutputReportAsync(HidOutputReport outputReport);

    IAsyncOperation<uint> SendFeatureReportAsync(HidFeatureReport featureReport);

    IVectorView<HidBooleanControlDescription> GetBooleanControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    IVectorView<HidNumericControlDescription> GetNumericControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    event TypedEventHandler<HidDevice, HidInputReportReceivedEventArgs> InputReportReceived;
  }
}
