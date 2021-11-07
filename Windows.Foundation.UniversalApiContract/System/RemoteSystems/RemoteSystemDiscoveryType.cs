// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemDiscoveryType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains the values that describe how remote systems are able to be discovered.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RemoteSystemDiscoveryType
  {
    /// <summary>Remote systems are discoverable both through a proximal connection and through cloud connection.</summary>
    Any,
    /// <summary>Remote systems are only discoverable through a proximal connection, such as a local network or Bluetooth connection.</summary>
    Proximal,
    /// <summary>Remote systems are only discoverable through cloud connection.</summary>
    Cloud,
    /// <summary>Remote systems are discoverable through a proximal connection and are expected to be spatially near to the client device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] SpatiallyProximal,
  }
}
