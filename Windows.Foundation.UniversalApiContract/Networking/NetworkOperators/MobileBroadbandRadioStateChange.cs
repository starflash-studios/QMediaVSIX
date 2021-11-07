// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandRadioStateChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains details of a radio state change notification.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MobileBroadbandRadioStateChange : IMobileBroadbandRadioStateChange
  {
    /// <summary>Gets the device ID of the device whose radio state changed.</summary>
    /// <returns>Unique ID of the device whose radio state changed.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the new state of the radio.</summary>
    /// <returns>The new state of the radio after a radio state change.</returns>
    public extern MobileBroadbandRadioState RadioState { [MethodImpl] get; }
  }
}
