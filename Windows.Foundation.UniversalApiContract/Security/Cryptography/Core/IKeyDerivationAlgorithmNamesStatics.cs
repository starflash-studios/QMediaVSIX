// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmNamesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(2070820414, 38098, 18233, 165, 123, 2, 46, 12, 58, 64, 42)]
  [ExclusiveTo(typeof (KeyDerivationAlgorithmNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyDerivationAlgorithmNamesStatics
  {
    string Pbkdf2Md5 { get; }

    string Pbkdf2Sha1 { get; }

    string Pbkdf2Sha256 { get; }

    string Pbkdf2Sha384 { get; }

    string Pbkdf2Sha512 { get; }

    string Sp800108CtrHmacMd5 { get; }

    string Sp800108CtrHmacSha1 { get; }

    string Sp800108CtrHmacSha256 { get; }

    string Sp800108CtrHmacSha384 { get; }

    string Sp800108CtrHmacSha512 { get; }

    string Sp80056aConcatMd5 { get; }

    string Sp80056aConcatSha1 { get; }

    string Sp80056aConcatSha256 { get; }

    string Sp80056aConcatSha384 { get; }

    string Sp80056aConcatSha512 { get; }
  }
}
