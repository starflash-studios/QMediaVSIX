// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppWithCampaignId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentApp))]
  [Guid(825183440, 14017, 17574, 179, 43, 67, 45, 96, 142, 77, 214)]
  internal interface ICurrentAppWithCampaignId
  {
    [RemoteAsync]
    IAsyncOperation<string> GetAppPurchaseCampaignIdAsync();
  }
}
