// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICommonReceiptSlipCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the capabilities common to receipt and slip printer stations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(153643915, 39027, 19717, 191, 190, 71, 39, 166, 3, 143, 105)]
  public interface ICommonReceiptSlipCapabilities : ICommonPosPrintStationCapabilities
  {
    /// <summary>Gets whether the receipt or slip printer station can print barcodes.</summary>
    /// <returns>True if the receipt or slip printer station can print barcodes; otherwise false.</returns>
    bool IsBarcodeSupported { get; }

    /// <summary>Gets whether the receipt or slip printer station can print bitmaps.</summary>
    /// <returns>True if the receipt or slip printer station can print bitmaps; otherwise false.</returns>
    bool IsBitmapSupported { get; }

    /// <summary>Gets whether the receipt or slip printer station can print information rotated 90 degrees to the left.</summary>
    /// <returns>True if the receipt or slip printer station can print information rotated 90 degrees to the left; otherwise false.</returns>
    bool IsLeft90RotationSupported { get; }

    /// <summary>Gets whether the receipt or slip printer station can print information rotated 90 degrees to the right.</summary>
    /// <returns>True if the receipt or slip printer station can print information rotated 90 degrees to the right; otherwise false.</returns>
    bool IsRight90RotationSupported { get; }

    /// <summary>Gets whether the receipt or slip printer station can print in a rotated upside-down mode.</summary>
    /// <returns>True if the receipt or slip printer station can print in a rotated upside-down mode; otherwise false.</returns>
    bool Is180RotationSupported { get; }

    /// <summary>Gets whether the receipt or slip printer station supports setting a custom size for the area of the page on which the printer station should print.</summary>
    /// <returns>True if the receipt or slip printer station supports setting a custom size for the area of the page on which the printer station should print; otherwise false.</returns>
    bool IsPrintAreaSupported { get; }

    /// <summary>Gets information about the capabilities of the receipt or slip printer station to draw ruled lines.</summary>
    /// <returns>Information about the capabilities of the printer station to draw ruled lines.</returns>
    PosPrinterRuledLineCapabilities RuledLineCapabilities { get; }

    /// <summary>Gets a list of the directions in which the receipt or slip printer station can rotate a barcode when printing.</summary>
    /// <returns>A list of the directions in which the receipt or slip printer station can rotate a barcode when printing.</returns>
    IVectorView<PosPrinterRotation> SupportedBarcodeRotations { get; }

    /// <summary>Gets a list of the directions in which the receipt or slip printer station can rotate a bitmap when printing.</summary>
    /// <returns>A list of the directions in which the receipt or slip printer station can rotate a bitmap when printing.</returns>
    IVectorView<PosPrinterRotation> SupportedBitmapRotations { get; }
  }
}
