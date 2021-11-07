// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Represents a top-level collection and the corresponding device.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHidDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HidDevice : IHidDevice, IClosable
  {
    /// <summary>Gets the vendor identifier for the given HID device.</summary>
    /// <returns>The vendor identifier.</returns>
    public extern ushort VendorId { [MethodImpl] get; }

    /// <summary>Gets the product identifier for the given HID device.</summary>
    /// <returns>The product identifier.</returns>
    public extern ushort ProductId { [MethodImpl] get; }

    /// <summary>Gets the version, or revision, number for the given HID device.</summary>
    /// <returns>The version number.</returns>
    public extern ushort Version { [MethodImpl] get; }

    /// <summary>Gets the usage page of the top-level collection.</summary>
    /// <returns>The usage page.</returns>
    public extern ushort UsagePage { [MethodImpl] get; }

    /// <summary>Gets the usage identifier for the given HID device.</summary>
    /// <returns>The usage identifier.</returns>
    public extern ushort UsageId { [MethodImpl] get; }

    /// <summary>Asynchronously retrieves the default, or first, input report from the given HID device.</summary>
    /// <returns>A **HidInputReport** object.</returns>
    [Overload("GetInputReportAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HidInputReport> GetInputReportAsync();

    /// <summary>Asynchronously retrieves an input report, identified by the *reportId* parameter, from the given HID device.</summary>
    /// <param name="reportId">Identifies the requested input report.</param>
    /// <returns>A **HidInputReport** object.</returns>
    [RemoteAsync]
    [Overload("GetInputReportByIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<HidInputReport> GetInputReportAsync(
      ushort reportId);

    /// <summary>Asynchronously retrieves the first, or default, feature report from the given HID device.</summary>
    /// <returns>A **HidFeatureReport** object.</returns>
    [Overload("GetFeatureReportAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HidFeatureReport> GetFeatureReportAsync();

    /// <summary>Asynchronously retrieves a feature report, identified by the *reportId* parameter, for the given HID device.</summary>
    /// <param name="reportId">Identifies the requested feature report.</param>
    /// <returns>A **HidFeatureReport** object.</returns>
    [RemoteAsync]
    [Overload("GetFeatureReportByIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<HidFeatureReport> GetFeatureReportAsync(
      ushort reportId);

    /// <summary>Creates the only, or default, output report that the host will send to the device.</summary>
    /// <returns>A **HidOutputReport** object.</returns>
    [Overload("CreateOutputReport")]
    [MethodImpl]
    public extern HidOutputReport CreateOutputReport();

    /// <summary>Creates an output report, identified by the *reportId* parameter, that the host will send to the device.</summary>
    /// <param name="reportId">Identifies the report being created.</param>
    /// <returns>A **HidOutputReport** object.</returns>
    [Overload("CreateOutputReportById")]
    [MethodImpl]
    public extern HidOutputReport CreateOutputReport(ushort reportId);

    /// <summary>Creates the only, or default, feature report that the host will send to the device.</summary>
    /// <returns>A **HidFeatureReport** object.</returns>
    [Overload("CreateFeatureReport")]
    [MethodImpl]
    public extern HidFeatureReport CreateFeatureReport();

    /// <summary>Creates a feature report, identified by the *reportId* parameter, that the host will send to the device.</summary>
    /// <param name="reportId">Identifies the report being created.</param>
    /// <returns>A **HidFeatureReport** object.</returns>
    [Overload("CreateFeatureReportById")]
    [MethodImpl]
    public extern HidFeatureReport CreateFeatureReport(ushort reportId);

    /// <summary>Sends an output report asynchronously from the host to the device.</summary>
    /// <param name="outputReport">The output report which the host sends to the device.</param>
    /// <returns>Specifies the count of bytes written to the device.</returns>
    [MethodImpl]
    public extern IAsyncOperation<uint> SendOutputReportAsync(
      HidOutputReport outputReport);

    /// <summary>Sends an feature report asynchronously from the host to the device.</summary>
    /// <param name="featureReport">The feature report which the host sends to the device.</param>
    /// <returns>The result of the asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncOperation<uint> SendFeatureReportAsync(
      HidFeatureReport featureReport);

    /// <summary>Retrieves the descriptions of the boolean controls for the given HID device.</summary>
    /// <param name="reportType">Specifies the type of report for which the control descriptions are requested.</param>
    /// <param name="usagePage">Identifies the usage page associated with the controls.</param>
    /// <param name="usageId">Identifies the usage associated with the controls.</param>
    /// <returns>A vector of HidBooleanControlDescription objects.</returns>
    [MethodImpl]
    public extern IVectorView<HidBooleanControlDescription> GetBooleanControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    /// <summary>Retrieves the descriptions of the numeric controls for the given HID device.</summary>
    /// <param name="reportType">Specifies the type of report for which the control descriptions are requested.</param>
    /// <param name="usagePage">Identifies the usage page associated with the controls.</param>
    /// <param name="usageId">Identifies the usage associated with the controls.</param>
    /// <returns>A vector of HidNumericControlDescription objects.</returns>
    [MethodImpl]
    public extern IVectorView<HidNumericControlDescription> GetNumericControlDescriptions(
      HidReportType reportType,
      ushort usagePage,
      ushort usageId);

    /// <summary>Establishes an event listener to handle input reports issued by the device when either GetInputReportAsync() or GetInputReportAsync(System.UInt16 reportId) is called.</summary>
    public extern event TypedEventHandler<HidDevice, HidInputReportReceivedEventArgs> InputReportReceived;

    [MethodImpl]
    public extern void Close();

    /// <summary>Retrieves an Advanced Query Syntax (AQS) string based on the given *usagePage* and *usageId*.</summary>
    /// <param name="usagePage">Specifies the usage page of the top-level collection for the given HID device.</param>
    /// <param name="usageId">Specifies the usage identifier of the top-level collection for the given HID device.</param>
    /// <returns>An Advanced Query Syntax (AQS) string that represents a device selector.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector(ushort usagePage, ushort usageId);

    /// <summary>Retrieves an Advanced Query Syntax (AQS) string based on the given *usagePage*, *usageId*, *vendorId*, and *productId*.</summary>
    /// <param name="usagePage">Specifies the usage page of the top-level collection for the given HID device.</param>
    /// <param name="usageId">Specifies the usage identifier of the top-level collection for the given HID device.</param>
    /// <param name="vendorId">Identifies the device vendor.</param>
    /// <param name="productId">Identifies the product.</param>
    /// <returns>An Advanced Query Syntax (AQS) string that represents a device selector.</returns>
    [Overload("GetDeviceSelectorVidPid")]
    [MethodImpl]
    public static extern string GetDeviceSelector(
      ushort usagePage,
      ushort usageId,
      ushort vendorId,
      ushort productId);

    /// <summary>Opens a handle to the device identified by the *deviceId* parameter. The access type is specified by the *accessMode* parameter.</summary>
    /// <param name="deviceId">The DeviceInformation ID that identifies the HID device.</param>
    /// <param name="accessMode">Specifies the access mode. The supported access modes are Read and ReadWrite.</param>
    /// <returns>A **HidDevice** object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<HidDevice> FromIdAsync(
      string deviceId,
      FileAccessMode accessMode);
  }
}
