// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListing2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(4171114767, 29694, 18765, 169, 57, 8, 169, 178, 73, 90, 190)]
  [ExclusiveTo(typeof (ProductListing))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IProductListing2
  {
    string FormattedBasePrice { get; }

    DateTime SaleEndDate { get; }

    bool IsOnSale { get; }

    string CurrencyCode { get; }
  }
}
