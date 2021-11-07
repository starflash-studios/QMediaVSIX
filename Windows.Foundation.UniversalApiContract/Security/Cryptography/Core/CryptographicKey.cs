// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicKey
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents a symmetric key or an asymmetric key pair.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class CryptographicKey : ICryptographicKey
  {
    /// <summary>Gets the size, in bits, of the key.</summary>
    /// <returns>Integer that contains the number of bits in the key.</returns>
    public extern uint KeySize { [MethodImpl] get; }

    /// <summary>Exports the key pair to a buffer.</summary>
    /// <returns>Buffer that contains the key pair.</returns>
    [Overload("ExportDefaultPrivateKeyBlobType")]
    [MethodImpl]
    public extern IBuffer Export();

    /// <summary>Exports the key pair to a buffer given a specified format.</summary>
    /// <param name="BlobType">A CryptographicPrivateKeyBlobType enumeration value that specifies the format of the key in the buffer. The default value is **Pkcs8RawPrivateKeyInfo**.</param>
    /// <returns>Buffer that contains the key pair.</returns>
    [Overload("ExportPrivateKeyWithBlobType")]
    [MethodImpl]
    public extern IBuffer Export(CryptographicPrivateKeyBlobType BlobType);

    /// <summary>Exports a public key to a buffer.</summary>
    /// <returns>Buffer that contains the public key.</returns>
    [Overload("ExportDefaultPublicKeyBlobType")]
    [MethodImpl]
    public extern IBuffer ExportPublicKey();

    /// <summary>Exports a public key to a buffer given a specified format.</summary>
    /// <param name="BlobType">A CryptographicPublicKeyBlobType enumeration value that specifies the format of the key in the buffer. The default value is **X509SubjectPublicKeyInfo**.</param>
    /// <returns>Buffer that contains the public key.</returns>
    [Overload("ExportPublicKeyWithBlobType")]
    [MethodImpl]
    public extern IBuffer ExportPublicKey(CryptographicPublicKeyBlobType BlobType);
  }
}
