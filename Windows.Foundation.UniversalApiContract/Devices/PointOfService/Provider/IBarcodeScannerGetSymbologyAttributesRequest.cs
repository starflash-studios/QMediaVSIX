﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerGetSymbologyAttributesRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerGetSymbologyAttributesRequest))]
  [Guid(2541012074, 22756, 19551, 184, 233, 228, 20, 103, 99, 39, 0)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IBarcodeScannerGetSymbologyAttributesRequest
  {
    uint Symbology { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(BarcodeSymbologyAttributes attributes);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}