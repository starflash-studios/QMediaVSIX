// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Provides a static method to get an instance of the default wallet store for this app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IWalletManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class WalletManager
  {
    /// <summary>Requests an instance of the default wallet store for the app.</summary>
    /// <returns>An asynchronous operation that, on successful completion, returns an instance of the default wallet store. If you use Asynchronous programming, the result type is a single WalletItemStore object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WalletItemStore> RequestStoreAsync();
  }
}
