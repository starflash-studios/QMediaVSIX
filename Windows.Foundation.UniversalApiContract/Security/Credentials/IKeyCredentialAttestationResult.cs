// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialAttestationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [Guid(2024453025, 41921, 16643, 182, 204, 71, 44, 68, 23, 28, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyCredentialAttestationResult))]
  internal interface IKeyCredentialAttestationResult
  {
    IBuffer CertificateChainBuffer { get; }

    IBuffer AttestationBuffer { get; }

    KeyCredentialAttestationStatus Status { get; }
  }
}
