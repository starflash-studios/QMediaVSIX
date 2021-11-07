// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletBarcode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [ExclusiveTo(typeof (WalletBarcode))]
  [Guid(1334147881, 56960, 20132, 161, 205, 129, 205, 8, 77, 172, 39)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletBarcode
  {
    WalletBarcodeSymbology Symbology { get; }

    string Value { get; }

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamReference> GetImageAsync();
  }
}
