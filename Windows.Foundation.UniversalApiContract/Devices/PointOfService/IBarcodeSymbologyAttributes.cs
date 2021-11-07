// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeSymbologyAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1715550840, 43898, 19162, 142, 206, 147, 96, 20, 178, 234, 215)]
  [ExclusiveTo(typeof (BarcodeSymbologyAttributes))]
  internal interface IBarcodeSymbologyAttributes
  {
    bool IsCheckDigitValidationEnabled { get; set; }

    bool IsCheckDigitValidationSupported { get; }

    bool IsCheckDigitTransmissionEnabled { get; set; }

    bool IsCheckDigitTransmissionSupported { get; }

    uint DecodeLength1 { get; set; }

    uint DecodeLength2 { get; set; }

    BarcodeSymbologyDecodeLengthKind DecodeLengthKind { get; set; }

    bool IsDecodeLengthSupported { get; }
  }
}
