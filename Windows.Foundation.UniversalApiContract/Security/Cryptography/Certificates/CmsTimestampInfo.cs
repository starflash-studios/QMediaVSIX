// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsTimestampInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents an RFC3161 unauthenticated timestamp attribute in a signed CMS message.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CmsTimestampInfo : ICmsTimestampInfo
  {
    /// <summary>Gets the certificate that is used to sign the timestamp.</summary>
    /// <returns>The certificate that is used to sign the timestamp.</returns>
    public extern Certificate SigningCertificate { [MethodImpl] get; }

    /// <summary>Gets the list of certificates that is used for chain building for the signing certificate.</summary>
    /// <returns>The list of certificates that is used for chain building for the signing certificate.</returns>
    public extern IVectorView<Certificate> Certificates { [MethodImpl] get; }

    /// <summary>Gets the date and time of the timestamp.</summary>
    /// <returns>The date and time of the timestamp.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }
  }
}
