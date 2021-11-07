// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductListing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (ProductListing))]
  [Guid(1168627373, 51024, 19868, 148, 124, 176, 13, 203, 249, 233, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProductListing
  {
    string ProductId { get; }

    string FormattedPrice { get; }

    string Name { get; }
  }
}
