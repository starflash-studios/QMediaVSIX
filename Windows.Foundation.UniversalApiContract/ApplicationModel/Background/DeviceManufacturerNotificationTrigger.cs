// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceManufacturerNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task to enable device manufacturer operations.</summary>
  /// <deprecated type="deprecate">DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IDeviceManufacturerNotificationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class DeviceManufacturerNotificationTrigger : 
    IDeviceManufacturerNotificationTrigger,
    IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of the DeviceManufacturerNotificationTrigger class.</summary>
    /// <deprecated type="deprecate">DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms</deprecated>
    /// <param name="triggerQualifier">An app-defined string that qualifies the trigger.</param>
    /// <param name="oneShot">Whether the trigger is used only once.</param>
    [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern DeviceManufacturerNotificationTrigger(string triggerQualifier, bool oneShot);

    /// <summary>Gets an app-defined string that qualifies the trigger.</summary>
    /// <returns>An app-defined string that qualifies the trigger.</returns>
    public extern string TriggerQualifier { [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets whether the trigger is used only once.</summary>
    /// <returns>True if the trigger is used only once.</returns>
    public extern bool OneShot { [Deprecated("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
