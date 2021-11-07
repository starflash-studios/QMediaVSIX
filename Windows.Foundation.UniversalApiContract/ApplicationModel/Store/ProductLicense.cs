// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductLicense
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Provides info about a license that is associated with an add-on (also called an in-app product or IAP).</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProductLicense : IProductLicense, IProductLicenseWithFulfillment
  {
    /// <summary>Gets the ID of an add-on (also called an in-app product or IAP). This ID is used by the app to get info about the product or feature that is enabled when the customer buys it through an in-app purchase.</summary>
    /// <returns>The ID specified in Partner Center to identify this add-on.</returns>
    public extern string ProductId { [MethodImpl] get; }

    /// <summary>Indicates if the add-on (also called an in-app product or IAP) license is currently active.</summary>
    /// <returns>Returns **true** if the add-on's license is active, and otherwise **false**. This property can return **false** if the license is missing, expired, or revoked.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Gets the current expiration date and time of the add-on (also called an in-app product or IAP) license.</summary>
    /// <returns>The date and time indicating when the add-on license expires.</returns>
    public extern DateTime ExpirationDate { [MethodImpl] get; }

    /// <summary>Indicates if the add-on (also called an in-app product or IAP) is consumable. A consumable add-on can be purchased, used, and purchased again.</summary>
    /// <returns>**true** if the add-on is a consumable add-on; Otherwise, **false**.</returns>
    public extern bool IsConsumable { [MethodImpl] get; }
  }
}
