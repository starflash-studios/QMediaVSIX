// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [Guid(1350921602, 9443, 18638, 153, 199, 112, 170, 193, 203, 201, 247)]
  [ExclusiveTo(typeof (BarcodeScannerProviderTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IBarcodeScannerProviderTriggerDetails
  {
    BarcodeScannerProviderConnection Connection { get; }
  }
}
