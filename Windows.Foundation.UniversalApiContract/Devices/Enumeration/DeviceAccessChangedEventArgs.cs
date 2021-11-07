// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceAccessChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Provides data for the AccessChanged event.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceAccessChangedEventArgs : 
    IDeviceAccessChangedEventArgs,
    IDeviceAccessChangedEventArgs2
  {
    /// <summary>The new status of access to a device.</summary>
    /// <returns>The new status of access to a device.</returns>
    public extern DeviceAccessStatus Status { [MethodImpl] get; }

    /// <summary>Gets the DeviceInformation ID of the device referenced by DeviceAccessChangedEventArgs.</summary>
    /// <returns>The DeviceInformation ID for the device.</returns>
    public extern string Id { [MethodImpl] get; }
  }
}
