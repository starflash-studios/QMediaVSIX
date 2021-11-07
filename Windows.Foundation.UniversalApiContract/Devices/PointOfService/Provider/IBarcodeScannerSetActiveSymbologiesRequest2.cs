// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerSetActiveSymbologiesRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerSetActiveSymbologiesRequest))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(4127157983, 64154, 18249, 177, 27, 232, 252, 203, 117, 188, 107)]
  internal interface IBarcodeScannerSetActiveSymbologiesRequest2
  {
    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAsync")]
    IAsyncAction ReportFailedAsync(int reason);

    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    [RemoteAsync]
    IAsyncAction ReportFailedAsync(int reason, string failedReasonDescription);
  }
}
