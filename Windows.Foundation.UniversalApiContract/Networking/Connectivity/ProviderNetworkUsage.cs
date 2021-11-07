// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ProviderNetworkUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents provider network usage statistics returned by the ConnectionProfile.GetProviderNetworkUsageAsync method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProviderNetworkUsage : IProviderNetworkUsage
  {
    /// <summary>Gets a value indicating the number of bytes sent by the connection over a specific period of time.</summary>
    /// <returns>The number of bytes sent.</returns>
    public extern ulong BytesSent { [MethodImpl] get; }

    /// <summary>Gets a value indicating the number of bytes received by a connection over a specific period of time.</summary>
    /// <returns>The number of bytes received.</returns>
    public extern ulong BytesReceived { [MethodImpl] get; }

    /// <summary>Gets the ProviderId (a combination of MCC and MNC).</summary>
    /// <returns>The ProviderId (a combination of MCC and MNC).</returns>
    public extern string ProviderId { [MethodImpl] get; }
  }
}
