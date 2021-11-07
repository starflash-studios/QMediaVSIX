// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerStopSoftwareTriggerRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [Guid(3411527133, 65104, 18936, 160, 180, 189, 194, 48, 129, 77, 162)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BarcodeScannerStopSoftwareTriggerRequest))]
  internal interface IBarcodeScannerStopSoftwareTriggerRequest2
  {
    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAsync")]
    IAsyncAction ReportFailedAsync(int reason);

    [RemoteAsync]
    [Overload("ReportFailedWithFailedReasonAndDescriptionAsync")]
    IAsyncAction ReportFailedAsync(int reason, string failedReasonDescription);
  }
}
