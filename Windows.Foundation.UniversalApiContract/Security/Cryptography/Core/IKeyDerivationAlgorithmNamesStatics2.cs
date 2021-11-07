// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmNamesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1469398955, 24644, 18031, 151, 244, 51, 123, 120, 8, 56, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyDerivationAlgorithmNames))]
  internal interface IKeyDerivationAlgorithmNamesStatics2
  {
    string CapiKdfMd5 { get; }

    string CapiKdfSha1 { get; }

    string CapiKdfSha256 { get; }

    string CapiKdfSha384 { get; }

    string CapiKdfSha512 { get; }
  }
}
