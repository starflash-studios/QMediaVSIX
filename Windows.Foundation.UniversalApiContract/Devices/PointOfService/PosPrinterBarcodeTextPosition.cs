// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterBarcodeTextPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the possible vertical positions in which a point-of-service printer prints the barcode text relative to the barcode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterBarcodeTextPosition
  {
    /// <summary>There is no barcode text.</summary>
    None,
    /// <summary>The barcode text is above the barcode.</summary>
    Above,
    /// <summary>The barcode text is below the barcode.</summary>
    Below,
  }
}
