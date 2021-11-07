// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.MacAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents a message authentication code (MAC). A MAC uses symmetric key cryptography to prevent message tampering. For more information, see MACs, hashes, and signatures.</summary>
  [Static(typeof (IMacAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MacAlgorithmProvider : IMacAlgorithmProvider, IMacAlgorithmProvider2
  {
    /// <summary>Gets the name of the open MAC algorithm.</summary>
    /// <returns>Algorithm name.</returns>
    public extern string AlgorithmName { [MethodImpl] get; }

    /// <summary>Gets the length, in bytes, of the message authentication code.</summary>
    /// <returns>Number of bytes in the MAC.</returns>
    public extern uint MacLength { [MethodImpl] get; }

    /// <summary>Creates a symmetric key that can be used to create the MAC value.</summary>
    /// <param name="keyMaterial">Random data used to help generate the key. You can call the GenerateRandom method to create the random data.</param>
    /// <returns>Symmetric key.</returns>
    [MethodImpl]
    public extern CryptographicKey CreateKey(IBuffer keyMaterial);

    /// <summary>Creates a CryptographicHash object that supports incremental hash operations.</summary>
    /// <param name="keyMaterial">Random data used to help generate the hash. You can call the GenerateRandom method to create the random data.</param>
    /// <returns>A CryptographicHash object that supports incremental hash operations.</returns>
    [MethodImpl]
    public extern CryptographicHash CreateHash(IBuffer keyMaterial);

    /// <summary>Creates a MacAlgorithmProvider object and opens the specified algorithm for use.</summary>
    /// <param name="algorithm">Algorithm name.</param>
    /// <returns>Represents a provider that implements MAC algorithms.</returns>
    [MethodImpl]
    public static extern MacAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
