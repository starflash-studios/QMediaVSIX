// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedCashDrawer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides access to exclusive and privileged methods, properties, and events on a point-of-service cash drawer device.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ClaimedCashDrawer : IClaimedCashDrawer, IClaimedCashDrawer2, IClosable
  {
    /// <summary>The identifier string of the claimed cash drawer device.</summary>
    /// <returns>String representing the ID of the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Indicates whether the cash drawer is operational and can be used.</summary>
    /// <returns>True if the cash drawer can be opened or CloseAlarm can be used; otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Indicates whether the cash drawer is open.</summary>
    /// <returns>True if the drawer is open, otherwise false.</returns>
    public extern bool IsDrawerOpen { [MethodImpl] get; }

    /// <summary>Gets the close alarm for this cash drawer. This is only valid if IsDrawerOpenSensorAvailable is true.</summary>
    /// <returns>The close alarm for the cash drawer.</returns>
    public extern CashDrawerCloseAlarm CloseAlarm { [MethodImpl] get; }

    /// <summary>Opens the cash drawer.</summary>
    /// <returns>Boolean indicating whether the drawer was successfully opened.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> OpenDrawerAsync();

    /// <summary>Asynchronously notifies the underlying hardware to power on for use.</summary>
    /// <returns>Whether the attempt to enable succeeded or not.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> EnableAsync();

    /// <summary>Notifies the underlying hardware to power off.</summary>
    /// <returns>Whether the attempt to disable succeeded or not.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> DisableAsync();

    /// <summary>Retain the current claim on the cash drawer. This is usually called in response to a ReleaseDeviceRequested event notification.</summary>
    /// <returns>True if the retain attempt succeeded; false if the retain attempt failed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RetainDeviceAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ResetStatisticsAsync(
      IIterable<string> statisticsCategories);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    /// <summary>Occurs when the device gets a request to release its exclusive claim.</summary>
    public extern event TypedEventHandler<ClaimedCashDrawer, object> ReleaseDeviceRequested;

    /// <summary>Event that is raised when the **ClaimedCashDrawer** is closed.</summary>
    public extern event TypedEventHandler<ClaimedCashDrawer, ClaimedCashDrawerClosedEventArgs> Closed;

    [MethodImpl]
    public extern void Close();
  }
}
