// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IMacAlgorithmProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (MacAlgorithmProvider))]
  [Guid(1839409685, 55601, 17133, 142, 126, 195, 1, 202, 238, 17, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMacAlgorithmProvider2
  {
    CryptographicHash CreateHash(IBuffer keyMaterial);
  }
}
