// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentApp2Statics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3746459181, 12657, 19155, 134, 20, 44, 97, 36, 67, 115, 203)]
  [ExclusiveTo(typeof (CurrentApp))]
  internal interface ICurrentApp2Statics
  {
    [RemoteAsync]
    IAsyncOperation<string> GetCustomerPurchaseIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    IAsyncOperation<string> GetCustomerCollectionsIdAsync(
      string serviceTicket,
      string publisherUserId);
  }
}
