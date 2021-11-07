// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAntennaSar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandAntennaSar))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3115273086, 52217, 16649, 144, 190, 92, 6, 191, 213, 19, 182)]
  internal interface IMobileBroadbandAntennaSar
  {
    int AntennaIndex { get; }

    int SarBackoffIndex { get; }
  }
}
