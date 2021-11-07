// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.UnfulfilledConsumable
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Contains purchase and product information for an unfulfilled consumable in-app product.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UnfulfilledConsumable : IUnfulfilledConsumable
  {
    /// <summary>A unique ID used to identify a consumable in-app product. This ID is used by the app to get info about the product or feature that is enabled when the customer buys it through an in-app purchase.</summary>
    /// <returns>The product ID.</returns>
    public extern string ProductId { [MethodImpl] get; }

    /// <summary>A unique ID used to identify the transaction that included the purchase of a consumable in-app product.</summary>
    /// <returns>The transaction ID.</returns>
    public extern Guid TransactionId { [MethodImpl] get; }

    /// <summary>A unique ID used to identify a consumable in-app product within a large purchase catalog.</summary>
    /// <returns>The offer ID.</returns>
    public extern string OfferId { [MethodImpl] get; }
  }
}
