// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceWatcherEvent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Triggered when the list of devices is updated after the initial enumeration is complete.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DeviceWatcherEvent : IDeviceWatcherEvent
  {
    /// <summary>Gets the type for the device indicated by the DeviceWatcherEvent.</summary>
    /// <returns>The type of device added, removed, or updated.</returns>
    public extern DeviceWatcherEventKind Kind { [MethodImpl] get; }

    /// <summary>Gets the information for the device associated with the DeviceWatcherEvent.</summary>
    /// <returns>The information for the added, removed, or updated device.</returns>
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    /// <summary>Gets updated information for a device updated by the DeviceWatcherEvent.</summary>
    /// <returns>The updated information for the modified device.</returns>
    public extern DeviceInformationUpdate DeviceInformationUpdate { [MethodImpl] get; }
  }
}
