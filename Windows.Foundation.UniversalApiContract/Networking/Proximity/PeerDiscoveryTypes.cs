﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerDiscoveryTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Indicates which discovery options are available to use with the PeerFinder class.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PeerDiscoveryTypes : uint
  {
    /// <summary>No supported discovery types are available. You can't use the PeerFinder class.</summary>
    None = 0,
    /// <summary>You can use Wifi-Direct to find peers by using the FindAllPeersAsync and ConnectAsync methods of the PeerFinder class.</summary>
    Browse = 1,
    /// <summary>You can tap to connect to peers by using the PeerFinder class.</summary>
    Triggered = 2,
  }
}