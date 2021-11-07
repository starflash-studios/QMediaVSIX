// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListingWithMetadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(307078503, 9208, 16958, 149, 50, 24, 153, 67, 196, 10, 206)]
  [ExclusiveTo(typeof (ProductListing))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProductListingWithMetadata : IProductListing
  {
    string Description { get; }

    IIterable<string> Keywords { get; }

    ProductType ProductType { get; }

    string Tag { get; }

    Uri ImageUri { get; }
  }
}
