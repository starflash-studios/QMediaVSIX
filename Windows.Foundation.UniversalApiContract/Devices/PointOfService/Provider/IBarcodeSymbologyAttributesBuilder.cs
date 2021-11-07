// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeSymbologyAttributesBuilder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BarcodeSymbologyAttributesBuilder))]
  [Guid(3313175743, 58613, 16569, 132, 207, 230, 63, 186, 234, 66, 180)]
  internal interface IBarcodeSymbologyAttributesBuilder
  {
    bool IsCheckDigitValidationSupported { get; set; }

    bool IsCheckDigitTransmissionSupported { get; set; }

    bool IsDecodeLengthSupported { get; set; }

    BarcodeSymbologyAttributes CreateAttributes();
  }
}
