// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents a provider of symmetric key algorithms. For more information, see Cryptographic keys.</summary>
  [Static(typeof (ISymmetricKeyAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class SymmetricKeyAlgorithmProvider : ISymmetricKeyAlgorithmProvider
  {
    /// <summary>Gets the name of the open symmetric algorithm.</summary>
    /// <returns>Algorithm name.</returns>
    public extern string AlgorithmName { [MethodImpl] get; }

    /// <summary>Gets the size, in bytes, of the cipher block for the open algorithm.</summary>
    /// <returns>Block size.</returns>
    public extern uint BlockLength { [MethodImpl] get; }

    /// <summary>Creates a symmetric key.</summary>
    /// <param name="keyMaterial">Data used to generate the key. You can call the GenerateRandom method to create random key material.</param>
    /// <returns>Symmetric key.</returns>
    [MethodImpl]
    public extern CryptographicKey CreateSymmetricKey(IBuffer keyMaterial);

    /// <summary>Creates an instance of the SymmetricKeyAlgorithmProvider class and opens the specified algorithm for use.</summary>
    /// <param name="algorithm">Algorithm name.</param>
    /// <returns>Represents a symmetric key algorithm provider.</returns>
    [MethodImpl]
    public static extern SymmetricKeyAlgorithmProvider OpenAlgorithm(
      string algorithm);
  }
}
