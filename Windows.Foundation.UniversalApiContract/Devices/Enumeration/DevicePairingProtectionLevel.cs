// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePairingProtectionLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>The level of protection for pairing.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DevicePairingProtectionLevel
  {
    /// <summary>The default value. This should not be used.</summary>
    Default,
    /// <summary>Pair the device using no levels of protection.</summary>
    None,
    /// <summary>Pair the device using encryption.</summary>
    Encryption,
    /// <summary>Pair the device using encryption and authentication.</summary>
    EncryptionAndAuthentication,
  }
}
