// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStorePreviewSkuInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ExclusiveTo(typeof (StorePreviewSkuInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2180871906, 2854, 18649, 152, 206, 39, 70, 28, 102, 157, 108)]
  internal interface IStorePreviewSkuInfo
  {
    string ProductId { get; }

    string SkuId { get; }

    string SkuType { get; }

    string Title { get; }

    string Description { get; }

    string CustomDeveloperData { get; }

    string CurrencyCode { get; }

    string FormattedListPrice { get; }

    string ExtendedData { get; }
  }
}
