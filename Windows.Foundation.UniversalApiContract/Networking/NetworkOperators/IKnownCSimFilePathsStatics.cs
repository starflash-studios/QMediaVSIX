// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IKnownCSimFilePathsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (KnownCSimFilePaths))]
  [Guid(3025710829, 18929, 19490, 176, 115, 150, 213, 17, 191, 156, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKnownCSimFilePathsStatics
  {
    IVectorView<uint> EFSpn { get; }

    IVectorView<uint> Gid1 { get; }

    IVectorView<uint> Gid2 { get; }
  }
}
