// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetwork3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(862390922, 51183, 17484, 171, 108, 223, 126, 247, 163, 144, 254)]
  [ExclusiveTo(typeof (MobileBroadbandNetwork))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMobileBroadbandNetwork3
  {
    [RemoteAsync]
    IAsyncOperation<MobileBroadbandCellsInfo> GetCellsInfoAsync();
  }
}
