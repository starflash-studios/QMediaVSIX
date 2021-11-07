// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.FulfillmentResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Defines values used to indicate fulfillment status for a consumable in-app product.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FulfillmentResult
  {
    /// <summary>The purchased consumable in-app product was fulfilled.</summary>
    Succeeded,
    /// <summary>The specified transaction ID has been passed or the consumable in-app product has already been fulfilled.</summary>
    NothingToFulfill,
    /// <summary>The purchase is not complete. At this point it is still possible for the transaction to be reversed due to provider failures and/or risk checks.</summary>
    PurchasePending,
    /// <summary>The purchase request has been reverted.</summary>
    PurchaseReverted,
    /// <summary>There was an issue receiving fulfillment status.</summary>
    ServerError,
  }
}
