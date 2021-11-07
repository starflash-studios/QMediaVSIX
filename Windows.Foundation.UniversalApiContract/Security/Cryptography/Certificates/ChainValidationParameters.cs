// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ChainValidationParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents values to use when verifying a certificate chain.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class ChainValidationParameters : IChainValidationParameters
  {
    /// <summary>Creates a new instance of the ChainValidationParameters class.</summary>
    [MethodImpl]
    public extern ChainValidationParameters();

    /// <summary>Gets or sets the certificate chain policy to use when verifying the certificate chain.</summary>
    /// <returns>The certificate chain policy to use when verifying the certificate chain.</returns>
    public extern CertificateChainPolicy CertificateChainPolicy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the server DNS name to use for SSL policy.</summary>
    /// <returns>The server DNS name to use for SSL policy.</returns>
    public extern HostName ServerDnsName { [MethodImpl] get; [MethodImpl] set; }
  }
}
