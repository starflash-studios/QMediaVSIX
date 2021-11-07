// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IHashAlgorithmNamesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1801323798, 56982, 20234, 141, 87, 220, 201, 218, 227, 108, 118)]
  [ExclusiveTo(typeof (HashAlgorithmNames))]
  internal interface IHashAlgorithmNamesStatics
  {
    string Md5 { get; }

    string Sha1 { get; }

    string Sha256 { get; }

    string Sha384 { get; }

    string Sha512 { get; }
  }
}
