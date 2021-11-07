// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletDetailViewPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Describes the position in the detail view of a wallet item that a WalletItemCustomProperty record should be displayed at.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WalletDetailViewPosition
  {
    /// <summary>This property is hidden from the detail view of the wallet item, but will be displayed on the back-of-card view of the item.</summary>
    Hidden,
    /// <summary>The first header slot in UI.</summary>
    HeaderField1,
    /// <summary>The second header slot in UI.</summary>
    HeaderField2,
    /// <summary>The first content slot in UI.</summary>
    PrimaryField1,
    /// <summary>The second content slot in UI.</summary>
    PrimaryField2,
    /// <summary>The first content slot in UI under Header2.</summary>
    SecondaryField1,
    /// <summary>The second content slot in UI under Header2.</summary>
    SecondaryField2,
    /// <summary>The third content slot in UI under Header2.</summary>
    SecondaryField3,
    /// <summary>The fourth content slot in UI under Header2.</summary>
    SecondaryField4,
    /// <summary>The fifth content slot in UI under Header2.</summary>
    SecondaryField5,
    /// <summary>If the value of the property at this position contains a URL (**http:// or https://**), the data is displayed as a button that can navigate to that URL.</summary>
    CenterField1,
    /// <summary>The first footer slot in UI.</summary>
    FooterField1,
    /// <summary>The second footer slot in UI.</summary>
    FooterField2,
    /// <summary>The third footer slot in UI.</summary>
    FooterField3,
    /// <summary>The fourth footer slot in UI.</summary>
    FooterField4,
  }
}
