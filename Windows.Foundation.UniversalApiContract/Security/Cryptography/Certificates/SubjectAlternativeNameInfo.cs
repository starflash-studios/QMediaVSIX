// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.SubjectAlternativeNameInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Provides info about a subject alternative name.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class SubjectAlternativeNameInfo : 
    ISubjectAlternativeNameInfo,
    ISubjectAlternativeNameInfo2
  {
    /// <summary>Creates a new instance of the SubjectAlternativeNameInfo class.</summary>
    [MethodImpl]
    public extern SubjectAlternativeNameInfo();

    /// <summary>Gets the email name.</summary>
    /// <returns>The email name.</returns>
    public extern IVectorView<string> EmailName { [MethodImpl] get; }

    /// <summary>Gets the IP address.</summary>
    /// <returns>The IP address.</returns>
    public extern IVectorView<string> IPAddress { [MethodImpl] get; }

    /// <summary>Gets the URL.</summary>
    /// <returns>The URL.</returns>
    public extern IVectorView<string> Url { [MethodImpl] get; }

    /// <summary>Gets the DNS name.</summary>
    /// <returns>The DNS name.</returns>
    public extern IVectorView<string> DnsName { [MethodImpl] get; }

    /// <summary>Gets the distinguished name.</summary>
    /// <returns>The distinguished name.</returns>
    public extern IVectorView<string> DistinguishedName { [MethodImpl] get; }

    /// <summary>Gets the principal name.</summary>
    /// <returns>The principal name.</returns>
    public extern IVectorView<string> PrincipalName { [MethodImpl] get; }

    /// <summary>Gets a vector of email names.</summary>
    /// <returns>A vector of email names.</returns>
    public extern IVector<string> EmailNames { [MethodImpl] get; }

    /// <summary>Gets the IP addresses.</summary>
    /// <returns>The IP addresses.</returns>
    public extern IVector<string> IPAddresses { [MethodImpl] get; }

    /// <summary>Gets a vector of URLs.</summary>
    /// <returns>A vector of URLs.</returns>
    public extern IVector<string> Urls { [MethodImpl] get; }

    /// <summary>Gets a vector of dns names.</summary>
    /// <returns>A vector of dns names.</returns>
    public extern IVector<string> DnsNames { [MethodImpl] get; }

    /// <summary>Gets a vector of distinguished names.</summary>
    /// <returns>A vector of distinguished names.</returns>
    public extern IVector<string> DistinguishedNames { [MethodImpl] get; }

    /// <summary>Gets a vector of principal names.</summary>
    /// <returns>A vector of principal names.</returns>
    public extern IVector<string> PrincipalNames { [MethodImpl] get; }

    /// <summary>Gets the certificate extension.</summary>
    /// <returns>The certificate extension.</returns>
    public extern CertificateExtension Extension { [MethodImpl] get; }
  }
}
