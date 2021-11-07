// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellUmts
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2008331694, 18888, 20245, 178, 133, 76, 38, 167, 246, 114, 21)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MobileBroadbandCellUmts))]
  internal interface IMobileBroadbandCellUmts
  {
    IReference<int> CellId { get; }

    IReference<int> ChannelNumber { get; }

    IReference<int> LocationAreaCode { get; }

    IReference<double> PathLossInDB { get; }

    IReference<int> PrimaryScramblingCode { get; }

    string ProviderId { get; }

    IReference<double> ReceivedSignalCodePowerInDBm { get; }

    IReference<double> SignalToNoiseRatioInDB { get; }
  }
}
