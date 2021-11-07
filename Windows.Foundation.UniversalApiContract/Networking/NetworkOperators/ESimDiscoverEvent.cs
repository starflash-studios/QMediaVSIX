// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimDiscoverEvent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class representing an eSIM profile discovery event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class ESimDiscoverEvent : IESimDiscoverEvent
  {
    /// <summary>Gets the matching ID of the event.</summary>
    /// <returns>A string containing the matching ID of the event.</returns>
    public extern string MatchingId { [MethodImpl] get; }

    /// <summary>Gets the RSP server address of the event.</summary>
    /// <returns>A string containing the RSP server address of the event.</returns>
    public extern string RspServerAddress { [MethodImpl] get; }
  }
}
