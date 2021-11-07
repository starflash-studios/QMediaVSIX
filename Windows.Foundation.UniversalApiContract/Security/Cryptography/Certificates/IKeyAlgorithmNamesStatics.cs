// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyAlgorithmNamesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1200645591, 31431, 17793, 140, 59, 208, 112, 39, 20, 4, 72)]
  [ExclusiveTo(typeof (KeyAlgorithmNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyAlgorithmNamesStatics
  {
    string Rsa { get; }

    string Dsa { get; }

    string Ecdh256 { get; }

    string Ecdh384 { get; }

    string Ecdh521 { get; }

    string Ecdsa256 { get; }

    string Ecdsa384 { get; }

    string Ecdsa521 { get; }
  }
}
