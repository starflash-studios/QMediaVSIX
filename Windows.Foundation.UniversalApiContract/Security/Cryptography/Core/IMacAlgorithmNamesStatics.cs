// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IMacAlgorithmNamesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1094788728, 64286, 17316, 137, 94, 169, 2, 110, 67, 144, 163)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MacAlgorithmNames))]
  internal interface IMacAlgorithmNamesStatics
  {
    string HmacMd5 { get; }

    string HmacSha1 { get; }

    string HmacSha256 { get; }

    string HmacSha384 { get; }

    string HmacSha512 { get; }

    string AesCmac { get; }
  }
}
