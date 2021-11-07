// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnManagementConnectionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Values used to report the current status of a VPN profile.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnManagementConnectionStatus
  {
    /// <summary>The profile is disconnected.</summary>
    Disconnected,
    /// <summary>The profile is in the process of disconnecting.</summary>
    Disconnecting,
    /// <summary>The profile is connected.</summary>
    Connected,
    /// <summary>The profile is in the process of connecting.</summary>
    Connecting,
  }
}
