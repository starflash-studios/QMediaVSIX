// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.PurchaseResults
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Contains information detailing the results of an in-app product purchase transaction.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PurchaseResults : IPurchaseResults
  {
    /// <summary>The current state of the purchase transaction for an in-app product.</summary>
    /// <returns>A purchase state value defined by the ProductPurchaseStatus enumeration.</returns>
    public extern ProductPurchaseStatus Status { [MethodImpl] get; }

    /// <summary>A unique transaction ID associated with the purchase of a consumable in-app product.</summary>
    /// <returns>A unique ID associated with a transaction.</returns>
    public extern Guid TransactionId { [MethodImpl] get; }

    /// <summary>A full receipt that provides a transaction history for the purchase of an in-app product.</summary>
    /// <returns>An XML-formatted string.</returns>
    public extern string ReceiptXml { [MethodImpl] get; }

    /// <summary>A unique ID used to identify a specific in-app product within a large catalog.</summary>
    /// <returns>Unique string used to identify a particular in-app product with a large catalog.</returns>
    public extern string OfferId { [MethodImpl] get; }
  }
}
