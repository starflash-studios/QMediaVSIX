// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.Battery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Power
{
  /// <summary>Provides information about a battery controller that is currently connected to the device. For more info, see [Get battery information](https://docs.microsoft.com/previous-versions/windows/apps/dn895210(v=win.10)).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBatteryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class Battery : IBattery
  {
    /// <summary>Gets the identifier (ID) for an individual battery controller.</summary>
    /// <returns>The battery controller identifier (ID).</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets a BatteryReport object that indicates the charge, capacity, and status of the battery or aggregate.</summary>
    /// <returns>Indicates the charge, capacity, and status of the battery or aggregate.</returns>
    [MethodImpl]
    public extern BatteryReport GetReport();

    /// <summary>&lt;!--***in what increments does this change? Can it return a battery  aggregate?***--&gt;</summary>
    public extern event TypedEventHandler<Battery, object> ReportUpdated;

    /// <summary>Gets a Battery object that represents all battery controllers connected to the device.</summary>
    /// <returns>A Battery object that represents overall battery power.</returns>
    public static extern Battery AggregateBattery { [MethodImpl] get; }

    /// <summary>Gets a Battery object that represents an individual battery controller connected to the device.</summary>
    /// <param name="deviceId">The device ID of the battery controller (DeviceId ).</param>
    /// <returns>A Battery object that corresponds to the specified battery controller.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Battery> FromIdAsync(string deviceId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string that can be used to find all battery controllers that are connected to the device.</summary>
    /// <returns>An AQS string that can be used to find all battery controllers connected to the device.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
