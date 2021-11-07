// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListingWithConsumables
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3953039248, 36715, 18463, 147, 167, 92, 58, 99, 6, 129, 73)]
  [ExclusiveTo(typeof (ProductListing))]
  internal interface IProductListingWithConsumables
  {
    ProductType ProductType { get; }
  }
}
