// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerSetSymbologyAttributesRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BarcodeScannerSetSymbologyAttributesRequest))]
  [Guid(3757817793, 56232, 19319, 190, 30, 181, 108, 215, 47, 101, 179)]
  internal interface IBarcodeScannerSetSymbologyAttributesRequest2
  {
    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAsync")]
    IAsyncAction ReportFailedAsync(int reason);

    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    [RemoteAsync]
    IAsyncAction ReportFailedAsync(int reason, string failedReasonDescription);
  }
}
