// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.KeyDerivationAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents a key derivation algorithm provider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IKeyDerivationAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class KeyDerivationAlgorithmProvider : IKeyDerivationAlgorithmProvider
  {
    /// <summary>Gets the name of the open key derivation function (KDF) algorithm.</summary>
    /// <returns>Algorithm name.</returns>
    public extern string AlgorithmName { [MethodImpl] get; }

    /// <summary>Creates a KDF key.</summary>
    /// <param name="keyMaterial">Data used to create the key.</param>
    /// <returns>Represents the KDF key.</returns>
    [MethodImpl]
    public extern CryptographicKey CreateKey(IBuffer keyMaterial);

    /// <summary>Creates an instance of the KeyDerivationAlgorithmProvider class and opens the specified algorithm for use.</summary>
    /// <param name="algorithm">Represents a KDF algorithm provider.</param>
    /// <returns>The algorithm provider.</returns>
    [MethodImpl]
    public static extern KeyDerivationAlgorithmProvider OpenAlgorithm(
      string algorithm);
  }
}
