// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ChainBuildingParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents parameters to use when building a certificate chain.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ChainBuildingParameters : IChainBuildingParameters
  {
    /// <summary>Creates a new instance of the ChainBuildingParameters class.</summary>
    [MethodImpl]
    public extern ChainBuildingParameters();

    /// <summary>Gets a collection of object identifiers (OIDs) for the enhanced key usage extension.</summary>
    /// <returns>A collection of object identifiers (OIDs) for the enhanced key usage extension.</returns>
    public extern IVector<string> EnhancedKeyUsages { [MethodImpl] get; }

    /// <summary>Gets or sets the time stamp used to determine whether the certificate chain was time valid.</summary>
    /// <returns>The time stamp used to determine whether the certificate chain was time valid.</returns>
    public extern DateTime ValidationTimestamp { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether revocation checking is enabled.</summary>
    /// <returns>True to enable revocation checking; otherwise false.</returns>
    public extern bool RevocationCheckEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether to request new URLs to use for chain building and revocation checking or to use cached URLs.</summary>
    /// <returns>True torequest new URLs to use for chain building and revocation checking; false to use cached URLs.</returns>
    public extern bool NetworkRetrievalEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether Authority Information Access (AIA) is enabled.</summary>
    /// <returns>True to enable Authority Information Access (AIA); otherwise false. The default is true.</returns>
    public extern bool AuthorityInformationAccessEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating that the current time is to be used for the validation timestamp.</summary>
    /// <returns>True to use the current time as the validation timestamp; otherwise false. The default is true.</returns>
    public extern bool CurrentTimeValidationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of root certificates that will be trusted.</summary>
    /// <returns>The list of root certificates that will be trusted.</returns>
    public extern IVector<Certificate> ExclusiveTrustRoots { [MethodImpl] get; }
  }
}
