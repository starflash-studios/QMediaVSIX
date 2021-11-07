// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductPurchaseDisplayPropertiesFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1867062772, 13014, 19264, 180, 116, 184, 48, 56, 164, 217, 207)]
  [ExclusiveTo(typeof (ProductPurchaseDisplayProperties))]
  internal interface IProductPurchaseDisplayPropertiesFactory
  {
    ProductPurchaseDisplayProperties CreateProductPurchaseDisplayProperties(
      string name);
  }
}
