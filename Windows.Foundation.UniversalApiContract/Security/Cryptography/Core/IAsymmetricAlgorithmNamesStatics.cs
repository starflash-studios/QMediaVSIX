// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricAlgorithmNamesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(3405184228, 26560, 18090, 132, 249, 117, 46, 119, 68, 159, 155)]
  [ExclusiveTo(typeof (AsymmetricAlgorithmNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAsymmetricAlgorithmNamesStatics
  {
    string RsaPkcs1 { get; }

    string RsaOaepSha1 { get; }

    string RsaOaepSha256 { get; }

    string RsaOaepSha384 { get; }

    string RsaOaepSha512 { get; }

    string EcdsaP256Sha256 { get; }

    string EcdsaP384Sha384 { get; }

    string EcdsaP521Sha512 { get; }

    string DsaSha1 { get; }

    string DsaSha256 { get; }

    string RsaSignPkcs1Sha1 { get; }

    string RsaSignPkcs1Sha256 { get; }

    string RsaSignPkcs1Sha384 { get; }

    string RsaSignPkcs1Sha512 { get; }

    string RsaSignPssSha1 { get; }

    string RsaSignPssSha256 { get; }

    string RsaSignPssSha384 { get; }

    string RsaSignPssSha512 { get; }
  }
}
