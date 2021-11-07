// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.CellularApnAuthenticationType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines values that indicate the authentication type used for a APN. These values are referenced when providing APN details using a CellularApnContext object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CellularApnAuthenticationType
  {
    /// <summary>No authentication.</summary>
    None,
    /// <summary>Password authentication.</summary>
    Pap,
    /// <summary>Challenge-Handshake authentication.</summary>
    Chap,
    /// <summary>Microsoft Challenge-Handshake authentication (v2)</summary>
    Mschapv2,
  }
}
