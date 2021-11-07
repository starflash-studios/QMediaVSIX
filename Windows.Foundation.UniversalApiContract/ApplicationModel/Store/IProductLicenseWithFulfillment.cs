// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductLicenseWithFulfillment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (ProductLicense))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4233321610, 63079, 16627, 186, 60, 4, 90, 99, 171, 179, 172)]
  internal interface IProductLicenseWithFulfillment : IProductLicense
  {
    bool IsConsumable { get; }
  }
}
