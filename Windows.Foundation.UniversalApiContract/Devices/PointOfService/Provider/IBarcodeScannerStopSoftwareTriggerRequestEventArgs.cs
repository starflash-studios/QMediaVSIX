// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerStopSoftwareTriggerRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BarcodeScannerStopSoftwareTriggerRequestEventArgs))]
  [Guid(3938665552, 20151, 18458, 146, 115, 20, 122, 39, 59, 153, 184)]
  internal interface IBarcodeScannerStopSoftwareTriggerRequestEventArgs
  {
    BarcodeScannerStopSoftwareTriggerRequest Request { get; }

    Deferral GetDeferral();
  }
}
