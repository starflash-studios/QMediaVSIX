// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPinManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines the PIN manager for a given mobile broadband modem and SIM Card.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandPinManager : IMobileBroadbandPinManager
  {
    /// <summary>Gets a list of the supported PIN types for the mobile broadband modem and SIM Card.</summary>
    /// <returns>a list of the supported PIN types for the mobile broadband modem and SIM Card.</returns>
    public extern IVectorView<MobileBroadbandPinType> SupportedPins { [MethodImpl] get; }

    /// <summary>Gets the mobile broadband PIN of a specific PIN type.</summary>
    /// <param name="pinType">The mobile broadband PIN type.</param>
    /// <returns>The mobile broadband PIN returned. This value is either provided by the end user or from a cache if allowed. .</returns>
    [MethodImpl]
    public extern MobileBroadbandPin GetPin(MobileBroadbandPinType pinType);
  }
}
