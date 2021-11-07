// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductPurchaseStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Defines values used to indicate the transaction status when purchasing an in-app product.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ProductPurchaseStatus
  {
    /// <summary>The transaction succeeded and the user has been notified.</summary>
    Succeeded,
    /// <summary>The transaction did not complete because this in-app product has already been purchased by the user, and it cannot be purchased again.</summary>
    AlreadyPurchased,
    /// <summary>The transaction did not complete because the last purchase of this consumable in-app product has not been reported as fulfilled to the Microsoft Store.</summary>
    NotFulfilled,
    /// <summary>The purchase did not occur because the user decided not to complete the transaction (or the transaction failed for other reasons).</summary>
    NotPurchased,
  }
}
