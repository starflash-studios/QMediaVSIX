// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Used to provide the product name that is displayed to the user at time of purchase. This class is used in the creation of a RequestProductPurchaseAsync operation to visually represent a specific offer within a large catalog of in-app products, which is represented by a single product entry in the Microsoft Store.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IProductPurchaseDisplayPropertiesFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProductPurchaseDisplayProperties : IProductPurchaseDisplayProperties
  {
    /// <summary>Creates an instance of ProductPurchaseDisplayProperties that includes the specified product name to display to the user.</summary>
    /// <param name="name">The product name displayed to the user.</param>
    [MethodImpl]
    public extern ProductPurchaseDisplayProperties(string name);

    /// <summary>Creates an instance of ProductPurchaseDisplayProperties.</summary>
    [MethodImpl]
    public extern ProductPurchaseDisplayProperties();

    /// <summary>Gets or sets the product name that is displayed to the user at time of purchase.</summary>
    /// <returns>The product name.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Windows Phone only. This is an internal product description.</summary>
    /// <returns>Internal product description.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Windows Phone only. Gets or sets the location of an image used to represent the product at time of purchase.</summary>
    /// <returns>The image location.</returns>
    public extern Uri Image { [MethodImpl] get; [MethodImpl] set; }
  }
}
