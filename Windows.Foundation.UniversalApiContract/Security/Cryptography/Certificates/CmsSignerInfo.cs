// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsSignerInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents signer information for a signed CMS message which contains a set of properties.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CmsSignerInfo : ICmsSignerInfo
  {
    /// <summary>Creates a new instance of the CmsSignerInfo class.</summary>
    [MethodImpl]
    public extern CmsSignerInfo();

    /// <summary>Gets or sets the signer certificate that is used to sign the message.</summary>
    /// <returns>The signer certificate that is used to sign the message.</returns>
    public extern Certificate Certificate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the hash algorithm that is used to sign the CMS message.</summary>
    /// <returns>The hash algorithm that is used to sign the CMS message.</returns>
    public extern string HashAlgorithmName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the RFC3161 unauthenticated timestamp information.</summary>
    /// <returns>The RFC3161 unauthenticated timestamp information.</returns>
    public extern CmsTimestampInfo TimestampInfo { [MethodImpl] get; }
  }
}
