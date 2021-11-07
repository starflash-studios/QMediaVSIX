// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletItemCustomProperty
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Defines a custom property on a wallet item. Apps can show data in the details view or back of card view of the item.</summary>
  [Activatable(typeof (IWalletItemCustomPropertyFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WalletItemCustomProperty : IWalletItemCustomProperty
  {
    /// <summary>Initializes a new instance of the WalletItemCustomProperty class.</summary>
    /// <param name="name">The custom property label. Sets the initial Name value.</param>
    /// <param name="value">The value of the property. Sets the initial Value value.</param>
    [MethodImpl]
    public extern WalletItemCustomProperty(string name, string value);

    /// <summary>Gets or sets the custom property label.</summary>
    /// <returns>The custom property label.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the custom property value.</summary>
    /// <returns>The custom property value.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether this WalletItemCustomProperty is entity-extracted and actionable upon display.</summary>
    /// <returns>**true** if the WalletItemCustomProperty is entity-extracted and actionable upon display; Otherwise, **false**.</returns>
    public extern bool AutoDetectLinks { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the optional position of this property when shown in the wallet item's detail view.</summary>
    /// <returns>The optional position of this property when shown in the wallet item's detail view, as a value of the enumeration. The default is **Hidden**.</returns>
    public extern WalletDetailViewPosition DetailViewPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the optional position of this property when shown in the summary view for a wallet item.</summary>
    /// <returns>The optional position of this property when shown in the summary view for a wallet item, as a value of the enumeration. The default is **Hidden**.</returns>
    public extern WalletSummaryViewPosition SummaryViewPosition { [MethodImpl] get; [MethodImpl] set; }
  }
}
