// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides details about one network registration state change.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MobileBroadbandNetworkRegistrationStateChange : 
    IMobileBroadbandNetworkRegistrationStateChange
  {
    /// <summary>Gets the unique identifier of the device associated with a network registration state change.</summary>
    /// <returns>Unique identifier of the device associated with a network registration state change notification.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets an object which contains details about the network associated with this network state change.</summary>
    /// <returns>Details about the network associated with a network registration state change notification.</returns>
    public extern MobileBroadbandNetwork Network { [MethodImpl] get; }
  }
}
