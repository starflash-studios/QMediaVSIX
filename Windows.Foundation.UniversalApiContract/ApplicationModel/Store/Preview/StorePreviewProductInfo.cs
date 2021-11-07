// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StorePreviewProductInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Provides information about an in-app product, including details about available SKUs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorePreviewProductInfo : IStorePreviewProductInfo
  {
    /// <summary>Gets the ID of the in-app product.</summary>
    /// <returns>The ID of the in-app product. This corresponds to the StorePreviewSkuInfo.ProductId value for all SKUs of the in-app product.</returns>
    public extern string ProductId { [MethodImpl] get; }

    /// <summary>Gets the type of the in-app product.</summary>
    /// <returns>One of the following strings that specifies the type of the in-app product. &lt;table&gt;</returns>
    public extern string ProductType { [MethodImpl] get; }

    /// <summary>Gets the name of the in-app product that is displayed to customers.</summary>
    /// <returns>The name of the in-app product that is displayed to customers.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the description of the in-app product.</summary>
    /// <returns>The description for the in-app product.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets information about the available SKUs for the in-app product.</summary>
    /// <returns>A list of StorePreviewSkuInfo objects that provide information about the available SKUs for the in-app product.</returns>
    public extern IVectorView<StorePreviewSkuInfo> SkuInfoList { [MethodImpl] get; }
  }
}
