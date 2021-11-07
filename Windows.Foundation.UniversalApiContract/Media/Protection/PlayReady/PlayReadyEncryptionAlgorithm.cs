// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyEncryptionAlgorithm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the type of encryption algorithm specified in a PlayReady content header.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PlayReadyEncryptionAlgorithm
  {
    /// <summary>Content is not encrypted.</summary>
    Unprotected = 0,
    /// <summary>AES-128 Counter-mode encryption.</summary>
    Aes128Ctr = 1,
    /// <summary>Cocktail encryption.</summary>
    Cocktail = 4,
    /// <summary>AES128CBC encryption.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Aes128Cbc = 5,
    /// <summary>The encryption method is unspecified.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Unspecified = 65535, // 0x0000FFFF
    /// <summary>The encryption method has not been set.</summary>
    Uninitialized = 2147483647, // 0x7FFFFFFF
  }
}
