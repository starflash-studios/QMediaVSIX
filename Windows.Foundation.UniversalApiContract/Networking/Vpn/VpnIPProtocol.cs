// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnIPProtocol
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Defines constants that specify IP protocols (numeric values).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnIPProtocol
  {
    /// <summary>Specifies no protocol.</summary>
    None = 0,
    /// <summary>Internet Control Message Protocol (ICMP)</summary>
    Icmp = 1,
    /// <summary>Internet Group Management Protocol (IGMP)</summary>
    Igmp = 2,
    /// <summary>Transmission Control Protocol (TCP)</summary>
    Tcp = 6,
    /// <summary>User Datagram Protocol (UDP)</summary>
    Udp = 17, // 0x00000011
    /// <summary>Internet Protocol version 6 (IPv6) Internet Control Message Protocol (ICMP)</summary>
    Ipv6Icmp = 58, // 0x0000003A
    /// <summary>Pragmatic General Multicast (PGM)</summary>
    Pgm = 113, // 0x00000071
  }
}
