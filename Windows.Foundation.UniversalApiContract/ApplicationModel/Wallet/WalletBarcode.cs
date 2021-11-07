// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletBarcode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Represents a bar code assigned to a wallet item.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWalletBarcodeFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WalletBarcode : IWalletBarcode
  {
    /// <summary>Initializes a new instance of the WalletBarcode class.</summary>
    /// <param name="symbology">The symbology type for this barcode. Use one of the supported symbologies, such as **Upca**. Don't set to **Invalid** or **Custom**.</param>
    /// <param name="value">The message (Value ) that the barcode represents.</param>
    [MethodImpl]
    public extern WalletBarcode(WalletBarcodeSymbology symbology, string value);

    /// <summary>Initializes a new instance of the WalletBarcode class.</summary>
    /// <param name="streamToBarcodeImage">A stream representing the bar code image.</param>
    [MethodImpl]
    public extern WalletBarcode(IRandomAccessStreamReference streamToBarcodeImage);

    /// <summary>Gets the symbology used by the bar code.</summary>
    /// <returns>The bar code's symbology.</returns>
    public extern WalletBarcodeSymbology Symbology { [MethodImpl] get; }

    /// <summary>Gets a string representation of the barcode (its message).</summary>
    /// <returns>The string representation of the barcode, which is the data message that the barcode represents.</returns>
    public extern string Value { [MethodImpl] get; }

    /// <summary>Creates and returns a bitmap image stream for the barcode (or returns the custom image used during instantiation).</summary>
    /// <returns>An asynchronous operation. If you use Asynchronous programming, the result type on successful completion is an IRandomAccessStreamReference instance. This can be assigned as the source for an image (with some additional code).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamReference> GetImageAsync();
  }
}
