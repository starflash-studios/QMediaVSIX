// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerEnableScannerRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [Guid(1906635432, 39173, 16812, 145, 33, 182, 69, 145, 106, 132, 161)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BarcodeScannerEnableScannerRequest))]
  internal interface IBarcodeScannerEnableScannerRequest2
  {
    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAsync")]
    IAsyncAction ReportFailedAsync(int reason);

    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    [RemoteAsync]
    IAsyncAction ReportFailedAsync(int reason, string failedReasonDescription);
  }
}
