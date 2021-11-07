// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnChannelRequestCredentialsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Specifies the values defining whether a requested credential is a retry case, or should be used for single sign on.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum VpnChannelRequestCredentialsOptions : uint
  {
    /// <summary>None.</summary>
    None = 0,
    /// <summary>Retrying.</summary>
    Retrying = 1,
    /// <summary>Use for single sign on.</summary>
    UseForSingleSignIn = 2,
  }
}
