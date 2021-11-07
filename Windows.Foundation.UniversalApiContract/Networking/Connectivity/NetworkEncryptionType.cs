// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkEncryptionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines values that indicate the type of encryption used for authentication.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NetworkEncryptionType
  {
    /// <summary>No encryption enabled.</summary>
    None,
    /// <summary>Encryption method unknown.</summary>
    Unknown,
    /// <summary>Specifies a WEP cipher algorithm with a cipher key of any length.</summary>
    Wep,
    /// <summary>Specifies a Wired Equivalent Privacy (WEP) algorithm, which is the RC4-based algorithm that is specified in the IEEE 802.11-1999 standard. This enumerator specifies the WEP cipher algorithm with a 40-bit cipher key.</summary>
    Wep40,
    /// <summary>Specifies a WEP cipher algorithm with a 104-bit cipher key.</summary>
    Wep104,
    /// <summary>Specifies a Temporal Key Integrity Protocol (TKIP) algorithm, which is the RC4-based cipher suite that is based on the algorithms that are defined in the WPA specification and IEEE 802.11i-2004 standard. This cipher also uses the Michael Message Integrity Code (MIC) algorithm for forgery protection.</summary>
    Tkip,
    /// <summary>Specifies an AES-CCMP algorithm, as specified in the IEEE 802.11i-2004 standard and RFC 3610. Advanced Encryption Standard (AES) is the encryption algorithm defined in FIPS PUB 197.</summary>
    Ccmp,
    /// <summary>Specifies a Wifi Protected Access (WPA) Use Group Key cipher suite. For more information about the Use Group Key cipher suite, refer to Clause 7.3.2.25.1 of the IEEE 802.11i-2004 standard.</summary>
    WpaUseGroup,
    /// <summary>Specifies a Robust Security Network (RSN) Use Group Key cipher suite. For more information about the Use Group Key cipher suite, refer to Clause 7.3.2.25.1 of the IEEE 802.11i-2004 standard.</summary>
    RsnUseGroup,
    /// <summary>Specifies an encryption type defined by an independent hardware vendor (IHV).</summary>
    Ihv,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] Gcmp,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] Gcmp256,
  }
}
