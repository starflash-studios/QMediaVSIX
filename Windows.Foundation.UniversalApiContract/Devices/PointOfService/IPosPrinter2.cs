// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (PosPrinter))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(612660712, 35736, 21783, 142, 72, 118, 14, 134, 246, 137, 135)]
  internal interface IPosPrinter2
  {
    IVectorView<uint> SupportedBarcodeSymbologies { get; }

    PosPrinterFontProperty GetFontProperty(string typeface);
  }
}
