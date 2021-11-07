// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPinLockStateChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains details of a PIN lock state change notification.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandPinLockStateChange : IMobileBroadbandPinLockStateChange
  {
    /// <summary>Gets the device identifier associated with a PIN lock state change.</summary>
    /// <returns>The unique device identifier associated with this PIN lock state change.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets a value representing the type of PIN involved in a PIN lock state change.</summary>
    /// <returns>An enumeration value describing the type of PIN whose state changed.</returns>
    public extern MobileBroadbandPinType PinType { [MethodImpl] get; }

    /// <summary>Gets a value representing the new PIN lock state after a PIN lock state change.</summary>
    /// <returns>An enumeration value indicating the new PIN lock state.</returns>
    public extern MobileBroadbandPinLockState PinLockState { [MethodImpl] get; }
  }
}
