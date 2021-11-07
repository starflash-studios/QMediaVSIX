// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerCapabilities2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (BarcodeScannerCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(4061253612, 57761, 20136, 154, 188, 146, 177, 89, 98, 112, 171)]
  internal interface IBarcodeScannerCapabilities2
  {
    bool IsVideoPreviewSupported { get; }
  }
}
