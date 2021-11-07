// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>A cash drawer device in a retail scenario.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICashDrawerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICashDrawerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class CashDrawer : ICashDrawer, IClosable
  {
    /// <summary>The identifier string of the cash drawer device.</summary>
    /// <returns>String representing the ID of the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>The functionality of the cash drawer device as exposed by API.</summary>
    /// <returns>The functionality of the cash drawer device as exposed by API.</returns>
    public extern CashDrawerCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Get the current power and availability status of the cash drawer.</summary>
    /// <returns>The cash drawer status.</returns>
    public extern CashDrawerStatus Status { [MethodImpl] get; }

    /// <summary>Indicates whether the cash drawer is open.</summary>
    /// <returns>True if the drawer is open, otherwise false.</returns>
    public extern bool IsDrawerOpen { [MethodImpl] get; }

    /// <summary>Gets the CashDrawerEventSource to allow the app to detect the open/close state of the drawer. The actual current state is reported by IsDrawerOpen..</summary>
    /// <returns>The cash drawer event source. If the drawer does not support open/close detection, then it will return null.</returns>
    public extern CashDrawerEventSource DrawerEventSource { [MethodImpl] get; }

    /// <summary>Attempts to get exclusive access on the cash drawer.</summary>
    /// <returns>When the method completes, it returns a ClaimedCashDrawer.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedCashDrawer> ClaimDrawerAsync();

    /// <summary>Gets the device's health state asynchronously.</summary>
    /// <param name="level">The specified health check level.</param>
    /// <returns>This value is intended to be reflected in the app interface immediately so the user of the app can interpret it. For example, it will return “OK” as the health string if the device state is good.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetStatisticsAsync(
      IIterable<string> statisticsCategories);

    /// <summary>Indicates there has been a change in the power availability status of the drawer.</summary>
    public extern event TypedEventHandler<CashDrawer, CashDrawerStatusUpdatedEventArgs> StatusUpdated;

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the cash drawers available over the specified connection types</summary>
    /// <param name="connectionTypes">A list of the connection types to check for available cash drawers.</param>
    /// <returns>An Advanced Query Syntax (AQS) string that is used to enumerate the cash drawers available over the specified connection types</returns>
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    /// <summary>Gets the default paired or locally-connected cash drawer.</summary>
    /// <returns>The default locally-connected drawer. May return null if there is no drawer available.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CashDrawer> GetDefaultAsync();

    /// <summary>Creates CashDrawer object from the DeviceInformation.Id.</summary>
    /// <param name="deviceId">The DeviceInformation.Id that identifies a specific cash drawer, which can be retrieved from the DeviceId property.</param>
    /// <returns>The cash drawer specified by the unique device identifier. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CashDrawer> FromIdAsync(
      string deviceId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the available cash drawers.</summary>
    /// <returns>An Advanced Query Syntax (AQS) string that is used to enumerate available cash drawers.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
