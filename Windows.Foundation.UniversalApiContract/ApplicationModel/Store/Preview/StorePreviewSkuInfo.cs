// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StorePreviewSkuInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Provides information about the available SKUs for an in-app product.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorePreviewSkuInfo : IStorePreviewSkuInfo
  {
    /// <summary>Gets the ID of the product that this SKU is associated with.</summary>
    /// <returns>The ID of the product that this SKU is associated with. This corresponds to the StorePreviewProductInfo.ProductId value.</returns>
    public extern string ProductId { [MethodImpl] get; }

    /// <summary>Gets the ID of this SKU.</summary>
    /// <returns>The ID of this SKU.</returns>
    public extern string SkuId { [MethodImpl] get; }

    /// <summary>Gets a string that specifies the type of the in-app product SKU.</summary>
    /// <returns>A string that specifies the type of the in-app product SKU.</returns>
    public extern string SkuType { [MethodImpl] get; }

    /// <summary>Gets the name of the in-app product SKU that is displayed to customers.</summary>
    /// <returns>The name of the in-app product SKU that is displayed to customers.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the description for the current SKU.</summary>
    /// <returns>The description for the current SKU.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets custom developer data for the current SKU.</summary>
    /// <returns>Custom developer data for the current SKU.</returns>
    public extern string CustomDeveloperData { [MethodImpl] get; }

    /// <summary>Gets the currency code for the current market.</summary>
    /// <returns>The currency code for the current market.</returns>
    public extern string CurrencyCode { [MethodImpl] get; }

    /// <summary>Gets the current SKU's purchase price with the appropriate formatting for the current market.</summary>
    /// <returns>The current SKU's purchase price with the appropriate formatting for the current market.</returns>
    public extern string FormattedListPrice { [MethodImpl] get; }

    /// <summary>Gets extended data for the current SKU.</summary>
    /// <returns>Extended data for the current SKU.</returns>
    public extern string ExtendedData { [MethodImpl] get; }
  }
}
