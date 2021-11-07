// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.HashAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents a cryptographic hash provider. For more information about hashes, see MACs, hashes, and signatures.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHashAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class HashAlgorithmProvider : IHashAlgorithmProvider
  {
    /// <summary>Gets the name of the open hash algorithm.</summary>
    /// <returns>Algorithm name.</returns>
    public extern string AlgorithmName { [MethodImpl] get; }

    /// <summary>Gets the length, in bytes, of the hash.</summary>
    /// <returns>Number of bytes in the hash.</returns>
    public extern uint HashLength { [MethodImpl] get; }

    /// <summary>Hashes binary data.</summary>
    /// <param name="data">Data to be hashed.</param>
    /// <returns>Hashed data.</returns>
    [MethodImpl]
    public extern IBuffer HashData(IBuffer data);

    /// <summary>Creates a reusable CryptographicHash object.</summary>
    /// <returns>Reusable hash object.</returns>
    [MethodImpl]
    public extern CryptographicHash CreateHash();

    /// <summary>Creates a HashAlgorithmProvider object and opens the specified algorithm for use.</summary>
    /// <param name="algorithm">Algorithm name.</param>
    /// <returns>Represents a provider that implements hash algorithms.</returns>
    [MethodImpl]
    public static extern HashAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
