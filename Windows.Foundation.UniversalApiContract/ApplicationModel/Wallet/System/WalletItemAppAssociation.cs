// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.WalletItemAppAssociation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet.System
{
  /// <summary>Defines values used by the GetAppStatusForItem method indicating if an app is installed for the specified WalletItem.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WalletItemAppAssociation
  {
    /// <summary>There is no app associated with the wallet item.</summary>
    None,
    /// <summary>The app for the wallet item is installed on this device.</summary>
    AppInstalled,
    /// <summary>An app exists for the wallet item, but it is not installed on the device.</summary>
    AppNotInstalled,
  }
}
