// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletItemKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Represents the kinds (classifications) of wallet items supported.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WalletItemKind
  {
    /// <summary>The item is invalid.</summary>
    Invalid,
    /// <summary>A deal.</summary>
    Deal,
    /// <summary>A general item.</summary>
    General,
    /// <summary>A payment instrument.</summary>
    PaymentInstrument,
    /// <summary>A ticket.</summary>
    Ticket,
    /// <summary>A boarding pass.</summary>
    BoardingPass,
    /// <summary>A membership card.</summary>
    MembershipCard,
  }
}
