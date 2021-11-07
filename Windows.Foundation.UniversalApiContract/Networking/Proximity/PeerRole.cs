// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerRole
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Describes the role of the peer app when connected to multiple peers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PeerRole
  {
    /// <summary>The app is part of a two-peer connection.</summary>
    Peer,
    /// <summary>The app is the host peer app in a multi-peer connection.</summary>
    Host,
    /// <summary>The app is a client peer app in a multi-peer connection.</summary>
    Client,
  }
}
