// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceWatcherTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Provides details about the device updates that invoked the trigger.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceWatcherTriggerDetails : IDeviceWatcherTriggerDetails
  {
    /// <summary>Gets the events that activated the trigger.</summary>
    /// <returns>The events that activated the watcher trigger.</returns>
    public extern IVectorView<DeviceWatcherEvent> DeviceWatcherEvents { [MethodImpl] get; }
  }
}
