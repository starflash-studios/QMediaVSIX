// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattProtectionLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents the desired security level.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GattProtectionLevel
  {
    /// <summary>Uses the default protection level.</summary>
    Plain,
    /// <summary>Require the link to be authenticated.</summary>
    AuthenticationRequired,
    /// <summary>Require the link to be encrypted.</summary>
    EncryptionRequired,
    /// <summary>Require the link to be encrypted and authenticated.</summary>
    EncryptionAndAuthenticationRequired,
  }
}
