// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Specifies the product type for an in-app product.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ProductType
  {
    /// <summary>The product type is unknown.</summary>
    Unknown,
    /// <summary>A durable product.</summary>
    Durable,
    /// <summary>A consumable product.</summary>
    Consumable,
  }
}
