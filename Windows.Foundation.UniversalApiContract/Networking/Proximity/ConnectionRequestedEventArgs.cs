// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.ConnectionRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Contains properties that are passed to an application with the ConnectionRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConnectionRequestedEventArgs : IConnectionRequestedEventArgs
  {
    /// <summary>Gets the information for a peer that's requesting a connection.</summary>
    /// <returns>The information for a peer that's requesting a connection.</returns>
    public extern PeerInformation PeerInformation { [MethodImpl] get; }
  }
}
