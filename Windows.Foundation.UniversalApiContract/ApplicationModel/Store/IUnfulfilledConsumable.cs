// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IUnfulfilledConsumable
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(771226555, 7389, 19640, 160, 20, 123, 156, 248, 152, 105, 39)]
  [ExclusiveTo(typeof (UnfulfilledConsumable))]
  internal interface IUnfulfilledConsumable
  {
    string ProductId { get; }

    Guid TransactionId { get; }

    string OfferId { get; }
  }
}
