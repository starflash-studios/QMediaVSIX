// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChangeTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides details for a network registration state change notification.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandNetworkRegistrationStateChangeTriggerDetails : 
    IMobileBroadbandNetworkRegistrationStateChangeTriggerDetails
  {
    /// <summary>Gets the collection of network registration state changes associated with this notification.</summary>
    /// <returns>A list of registration state changes.</returns>
    public extern IVectorView<MobileBroadbandNetworkRegistrationStateChange> NetworkRegistrationStateChanges { [MethodImpl] get; }
  }
}
