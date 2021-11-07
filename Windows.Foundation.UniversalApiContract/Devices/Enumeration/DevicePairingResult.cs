// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePairingResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Contains information about the result of attempting to pair a device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class DevicePairingResult : IDevicePairingResult
  {
    /// <summary>Gets the paired status of the device after the pairing action completed.</summary>
    /// <returns>The paired status of the device.</returns>
    public extern DevicePairingResultStatus Status { [MethodImpl] get; }

    /// <summary>Gets the level of protection used to pair the device.</summary>
    /// <returns>The level of protection used when the device was paired.</returns>
    public extern DevicePairingProtectionLevel ProtectionLevelUsed { [MethodImpl] get; }
  }
}
