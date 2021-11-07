// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3322319332, 62152, 17440, 163, 7, 177, 46, 246, 98, 40, 87)]
  [ExclusiveTo(typeof (BarcodeScannerCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeScannerCapabilities
  {
    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    bool IsImagePreviewSupported { get; }
  }
}
