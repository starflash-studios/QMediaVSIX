// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3454621473, 17280, 18821, 173, 197, 57, 219, 48, 205, 147, 188)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PosPrinterCapabilities))]
  internal interface IPosPrinterCapabilities
  {
    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    uint DefaultCharacterSet { get; }

    bool HasCoverSensor { get; }

    bool CanMapCharacterSet { get; }

    bool IsTransactionSupported { get; }

    ReceiptPrinterCapabilities Receipt { get; }

    SlipPrinterCapabilities Slip { get; }

    JournalPrinterCapabilities Journal { get; }
  }
}
