// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAntennaSarFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MobileBroadbandAntennaSar))]
  [Guid(2837321494, 49229, 18977, 134, 152, 20, 89, 220, 103, 44, 110)]
  internal interface IMobileBroadbandAntennaSarFactory
  {
    MobileBroadbandAntennaSar CreateWithIndex(
      int antennaIndex,
      int sarBackoffIndex);
  }
}
