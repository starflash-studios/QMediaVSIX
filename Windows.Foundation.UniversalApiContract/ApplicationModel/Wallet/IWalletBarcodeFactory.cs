// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletBarcodeFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [Guid(806449505, 60828, 18078, 187, 253, 48, 108, 149, 234, 113, 8)]
  [ExclusiveTo(typeof (WalletBarcode))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletBarcodeFactory
  {
    WalletBarcode CreateWalletBarcode(WalletBarcodeSymbology symbology, string value);

    WalletBarcode CreateCustomWalletBarcode(
      IRandomAccessStreamReference streamToBarcodeImage);
  }
}
