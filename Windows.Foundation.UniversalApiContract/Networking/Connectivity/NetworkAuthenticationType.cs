// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkAuthenticationType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines values that indicate the type of authentication used by the network.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NetworkAuthenticationType
  {
    /// <summary>No authentication enabled.</summary>
    None = 0,
    /// <summary>Authentication method unknown.</summary>
    Unknown = 1,
    /// <summary>Open authentication over 802.11 wireless. Devices are authenticated and can connect to an access point, but communication with the network requires a matching Wired Equivalent Privacy (WEP) key.</summary>
    Open80211 = 2,
    /// <summary>Specifies an IEEE 802.11 Shared Key authentication algorithm that requires the use of a pre-shared Wired Equivalent Privacy (WEP) key for the 802.11 authentication.</summary>
    SharedKey80211 = 3,
    /// <summary>Specifies a Wi-Fi Protected Access (WPA) algorithm. IEEE 802.1X port authorization is performed by the supplicant, authenticator, and authentication server. Cipher keys are dynamically derived through the authentication process.</summary>
    Wpa = 4,
    /// <summary>Specifies a Wi-Fi Protected Access (WPA) algorithm that uses pre-shared keys (PSK). IEEE 802.1X port authorization is performed by the supplicant and authenticator. Cipher keys are dynamically derived through a pre-shared key that is used on both the supplicant and authenticator.</summary>
    WpaPsk = 5,
    /// <summary>Wi-Fi Protected Access.</summary>
    WpaNone = 6,
    /// <summary>Specifies an IEEE 802.11i Robust Security Network Association (RSNA) algorithm. IEEE 802.1X port authorization is performed by the supplicant, authenticator, and authentication server. Cipher keys are dynamically derived through the authentication process.</summary>
    Rsna = 7,
    /// <summary>Specifies an IEEE 802.11i RSNA algorithm that uses PSK. IEEE 802.1X port authorization is performed by the supplicant and authenticator. Cipher keys are dynamically derived through a pre-shared key that is used on both the supplicant and authenticator.</summary>
    RsnaPsk = 8,
    /// <summary>Specifies an authentication type defined by an independent hardware vendor (IHV).</summary>
    Ihv = 9,
    /// <summary>Specifies a Wi-Fi Protected Access 3 (WPA3) algorithm. WPA3 is an encryption security standard for enterprise users. It offers the equivalent of 192-bit cryptographic strength, providing additional protections for networks transmitting sensitive data.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] Wpa3 = 10, // 0x0000000A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] Wpa3Enterprise192Bits = 10, // 0x0000000A
    /// <summary>Specifies a Wi-Fi Protected Access 3 Simultaneous Authentication of Equals (WPA3 SAE) algorithm. WPA3 SAE is the consumer version of WPA3. Simultaneous Authentication of Equals (SAE) is a secure key establishment protocol between devices; it provides synchronous authentication, and stronger protections for users against password-guessing attempts by third parties.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] Wpa3Sae = 11, // 0x0000000B
    /// <summary>Specifies an opportunistic wireless encryption (OWE) algorithm. OWE provides opportunistic encryption over 802.11 wireless, where cipher keys are dynamically derived through a Diffie-Hellman key exchange; enabling data protection without authentication.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] Owe = 12, // 0x0000000C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] Wpa3Enterprise = 13, // 0x0000000D
  }
}
