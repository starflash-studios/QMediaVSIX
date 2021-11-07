﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnAppIdType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Specifies the type of AppId understood by the VPN platform.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnAppIdType
  {
    /// <summary>Package family name.</summary>
    PackageFamilyName,
    /// <summary>Fully qualified binary name (FQBN).</summary>
    FullyQualifiedBinaryName,
    /// <summary>File path.</summary>
    FilePath,
  }
}