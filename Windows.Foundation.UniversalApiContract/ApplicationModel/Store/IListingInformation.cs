// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IListingInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(1485523647, 48244, 17283, 183, 140, 153, 96, 99, 35, 222, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListingInformation))]
  internal interface IListingInformation
  {
    string CurrentMarket { get; }

    string Description { get; }

    IMapView<string, ProductListing> ProductListings { get; }

    string FormattedPrice { get; }

    string Name { get; }

    uint AgeRating { get; }
  }
}
