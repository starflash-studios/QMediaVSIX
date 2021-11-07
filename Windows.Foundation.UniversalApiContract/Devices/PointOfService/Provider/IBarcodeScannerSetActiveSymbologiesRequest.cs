// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerSetActiveSymbologiesRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerSetActiveSymbologiesRequest))]
  [Guid(3678352057, 63450, 16801, 159, 121, 7, 188, 217, 95, 11, 223)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IBarcodeScannerSetActiveSymbologiesRequest
  {
    IVectorView<uint> Symbologies { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
