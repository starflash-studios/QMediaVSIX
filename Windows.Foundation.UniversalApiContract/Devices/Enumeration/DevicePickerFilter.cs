// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePickerFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Represents the filter used to determine which devices to show in the device picker. The filter parameters are OR-ed together to build the resulting filter.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DevicePickerFilter : IDevicePickerFilter
  {
    /// <summary>Gets a list of supported device classes to show in the picker. This defaults to an empty list (no filter). You can add device classes to this vector and filter the devices list to those that are in one or more of the provided classes.</summary>
    /// <returns>The list of device classes.</returns>
    public extern IVector<DeviceClass> SupportedDeviceClasses { [MethodImpl] get; }

    /// <summary>Gets a list of AQS filter strings. This defaults to empty list (no filter). You can add one or more AQS filter strings to this vector and filter the devices list to those that meet one or more of the provided filters.</summary>
    /// <returns>The list of AQS filters.</returns>
    public extern IVector<string> SupportedDeviceSelectors { [MethodImpl] get; }
  }
}
