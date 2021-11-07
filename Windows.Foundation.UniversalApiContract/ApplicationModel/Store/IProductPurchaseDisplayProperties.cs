// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductPurchaseDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Guid(3607852064, 48274, 16411, 168, 9, 201, 178, 229, 219, 189, 175)]
  [ExclusiveTo(typeof (ProductPurchaseDisplayProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProductPurchaseDisplayProperties
  {
    string Name { get; set; }

    string Description { get; set; }

    Uri Image { get; set; }
  }
}
