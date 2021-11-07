// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletBarcodeSymbology
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Represents the barcode symbology types that are supported for a WalletItem.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WalletBarcodeSymbology
  {
    /// <summary>Invalid barcode type.</summary>
    Invalid = 0,
    /// <summary>Uses the **UPC-A** barcode symbology.</summary>
    Upca = 1,
    /// <summary>Uses the **UPC-E** barcode symbology.</summary>
    Upce = 2,
    /// <summary>Uses the **EAN-13** barcode symbology.</summary>
    Ean13 = 3,
    /// <summary>Uses the **EAN-8** barcode symbology.</summary>
    Ean8 = 4,
    /// <summary>Uses the **ITF** barcode symbology.</summary>
    Itf = 5,
    /// <summary>Uses the **Code 39** barcode symbology.</summary>
    Code39 = 6,
    /// <summary>Uses the **Code 128** barcode symbology.</summary>
    Code128 = 7,
    /// <summary>Uses the **QR Code** barcode symbology.</summary>
    Qr = 8,
    /// <summary>Uses the **PDF417** barcode symbology.</summary>
    Pdf417 = 9,
    /// <summary>Uses the **Aztec** barcode symbology.</summary>
    Aztec = 10, // 0x0000000A
    /// <summary>Uses a custom bar code symbology.</summary>
    Custom = 100000, // 0x000186A0
  }
}
