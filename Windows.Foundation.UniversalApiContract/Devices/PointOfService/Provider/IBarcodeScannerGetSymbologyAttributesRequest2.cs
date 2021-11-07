// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerGetSymbologyAttributesRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [Guid(1785342739, 30120, 18939, 184, 82, 191, 185, 61, 118, 10, 247)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BarcodeScannerGetSymbologyAttributesRequest))]
  internal interface IBarcodeScannerGetSymbologyAttributesRequest2
  {
    [Overload("ReportFailedWithFailedReasonAsync")]
    [RemoteAsync]
    IAsyncAction ReportFailedAsync(int reason);

    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    IAsyncAction ReportFailedAsync(int reason, string failedReasonDescription);
  }
}
