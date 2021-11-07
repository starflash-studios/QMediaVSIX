﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnAuthenticationMethod
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Specifies the type of authentication methods allowed by the operating system native VPN protocols.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnAuthenticationMethod
  {
    /// <summary>Microsoft Challenge-Handshake Authentication Protocol v2</summary>
    Mschapv2,
    /// <summary>Extensible Authentication Protocol</summary>
    Eap,
    /// <summary>Certificate</summary>
    Certificate,
    /// <summary>Preshared key</summary>
    PresharedKey,
  }
}