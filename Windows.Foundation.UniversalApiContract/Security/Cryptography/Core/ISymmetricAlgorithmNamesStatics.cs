// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ISymmetricAlgorithmNamesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (SymmetricAlgorithmNames))]
  [Guid(1752199803, 51606, 20142, 132, 215, 121, 178, 174, 183, 59, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISymmetricAlgorithmNamesStatics
  {
    string DesCbc { get; }

    string DesEcb { get; }

    string TripleDesCbc { get; }

    string TripleDesEcb { get; }

    string Rc2Cbc { get; }

    string Rc2Ecb { get; }

    string AesCbc { get; }

    string AesEcb { get; }

    string AesGcm { get; }

    string AesCcm { get; }

    string AesCbcPkcs7 { get; }

    string AesEcbPkcs7 { get; }

    string DesCbcPkcs7 { get; }

    string DesEcbPkcs7 { get; }

    string TripleDesCbcPkcs7 { get; }

    string TripleDesEcbPkcs7 { get; }

    string Rc2CbcPkcs7 { get; }

    string Rc2EcbPkcs7 { get; }

    string Rc4 { get; }
  }
}
