// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IProductLicense
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (ProductLicense))]
  [Guid(909314247, 11215, 19470, 143, 47, 232, 8, 170, 168, 249, 157)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProductLicense
  {
    string ProductId { get; }

    bool IsActive { get; }

    DateTime ExpirationDate { get; }
  }
}
