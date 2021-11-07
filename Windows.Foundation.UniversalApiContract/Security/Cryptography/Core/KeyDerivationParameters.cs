// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.KeyDerivationParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents parameters used when deriving a key.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IKeyDerivationParametersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IKeyDerivationParametersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class KeyDerivationParameters : IKeyDerivationParameters, IKeyDerivationParameters2
  {
    /// <summary>Gets or sets the parameters used by the key derivation algorithm.</summary>
    /// <returns>Buffer that contains the parameters.</returns>
    public extern IBuffer KdfGenericBinary { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves the number of iterations used to derive the key. For more information, see BuildForPbkdf2.</summary>
    /// <returns>Iteration count.</returns>
    public extern uint IterationCount { [MethodImpl] get; }

    /// <summary>Gets or sets the Capi1KdfTargetAlgorithm.</summary>
    /// <returns>The Capi1KdfTargetAlgorithm.</returns>
    public extern Capi1KdfTargetAlgorithm Capi1KdfTargetAlgorithm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a KeyDerivationParameters object for use in the target algorithm.</summary>
    /// <param name="capi1KdfTargetAlgorithm">The target algorithm.</param>
    /// <returns>Refers to the parameters used during key derivation.</returns>
    [MethodImpl]
    public static extern KeyDerivationParameters BuildForCapi1Kdf(
      Capi1KdfTargetAlgorithm capi1KdfTargetAlgorithm);

    /// <summary>Creates a KeyDerivationParameters object for use in the password-based key derivation function 2 (PBKDF2).</summary>
    /// <param name="pbkdf2Salt">The salt, a random or pseudorandom value to be combined with the password in multiple iterations. A salt is used to increase entropy above what can be obtained from using a password alone.</param>
    /// <param name="iterationCount">Number of iterations to be used to derive a key.</param>
    /// <returns>Refers to the parameters used during key derivation.</returns>
    [MethodImpl]
    public static extern KeyDerivationParameters BuildForPbkdf2(
      IBuffer pbkdf2Salt,
      uint iterationCount);

    /// <summary>Creates a KeyDerivationParameters object for use in a counter mode, hash-based message authentication code (HMAC) key derivation function.</summary>
    /// <param name="label">Buffer that specifies the purpose for the derived keying material.</param>
    /// <param name="context">Buffer that specifies information related to the derived keying material. For example, the context can identify the parties who are deriving the keying material and, optionally, a nonce known by the parties.</param>
    /// <returns>Refers to the parameters used during key derivation.</returns>
    [MethodImpl]
    public static extern KeyDerivationParameters BuildForSP800108(
      IBuffer label,
      IBuffer context);

    /// <summary>Creates a KeyDerivationParameters object for use in the SP800-56A key derivation function.</summary>
    /// <param name="algorithmId">Specifies the intended purpose of the derived key.</param>
    /// <param name="partyUInfo">Contains public information contributed by the initiator.</param>
    /// <param name="partyVInfo">Contains public information contributed by the responder.</param>
    /// <param name="suppPubInfo">Contains public information known to both initiator and responder.</param>
    /// <param name="suppPrivInfo">Contains private information known to both initiator and responder, such as a shared secret.</param>
    /// <returns>Refers to the parameters used during key derivation.</returns>
    [MethodImpl]
    public static extern KeyDerivationParameters BuildForSP80056a(
      IBuffer algorithmId,
      IBuffer partyUInfo,
      IBuffer partyVInfo,
      IBuffer suppPubInfo,
      IBuffer suppPrivInfo);
  }
}
