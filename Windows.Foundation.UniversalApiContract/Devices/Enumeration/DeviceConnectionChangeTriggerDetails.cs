// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceConnectionChangeTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Provides information about the device that caused this trigger to fire.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DeviceConnectionChangeTriggerDetails : IDeviceConnectionChangeTriggerDetails
  {
    /// <summary>Gets the device Id of the device that caused this trigger to fire.</summary>
    /// <returns>The device id of the device that caused this trigger to fire.</returns>
    public extern string DeviceId { [MethodImpl] get; }
  }
}
