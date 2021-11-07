// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerDisableScannerRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3437225509, 26051, 19660, 180, 87, 243, 156, 122, 158, 166, 13)]
  [ExclusiveTo(typeof (BarcodeScannerDisableScannerRequest))]
  internal interface IBarcodeScannerDisableScannerRequest2
  {
    [Overload("ReportFailedWithFailedReasonAsync")]
    [RemoteAsync]
    IAsyncAction ReportFailedAsync(int reason);

    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    [RemoteAsync]
    IAsyncAction ReportFailedAsync(int reason, string failedReasonDescription);
  }
}
