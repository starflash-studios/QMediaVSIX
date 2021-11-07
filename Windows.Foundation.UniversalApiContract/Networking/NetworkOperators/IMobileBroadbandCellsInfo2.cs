// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellsInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(1713395986, 47263, 19986, 187, 182, 213, 207, 9, 168, 32, 202)]
  [ExclusiveTo(typeof (MobileBroadbandCellsInfo))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  internal interface IMobileBroadbandCellsInfo2
  {
    IVectorView<MobileBroadbandCellNR> NeighboringCellsNR { get; }

    IVectorView<MobileBroadbandCellNR> ServingCellsNR { get; }
  }
}
