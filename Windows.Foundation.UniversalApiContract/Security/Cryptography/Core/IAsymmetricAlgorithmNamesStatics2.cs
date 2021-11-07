// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricAlgorithmNamesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4047618262, 19455, 20259, 186, 102, 96, 69, 177, 55, 213, 223)]
  [ExclusiveTo(typeof (AsymmetricAlgorithmNames))]
  internal interface IAsymmetricAlgorithmNamesStatics2
  {
    string EcdsaSha256 { get; }

    string EcdsaSha384 { get; }

    string EcdsaSha512 { get; }
  }
}
