// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerCapabilities1
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (BarcodeScannerCapabilities))]
  [Guid(2388308969, 3628, 18223, 161, 204, 238, 128, 84, 182, 166, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeScannerCapabilities1
  {
    bool IsSoftwareTriggerSupported { get; }
  }
}
