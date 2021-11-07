// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListServerSearchReadBatchRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ExclusiveTo(typeof (ContactListServerSearchReadBatchRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3128388247, 16432, 18725, 159, 180, 20, 59, 41, 94, 101, 59)]
  internal interface IContactListServerSearchReadBatchRequest
  {
    string SessionId { get; }

    string ContactListId { get; }

    ContactQueryOptions Options { get; }

    uint SuggestedBatchSize { get; }

    [RemoteAsync]
    IAsyncAction SaveContactAsync(Contact contact);

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync(ContactBatchStatus batchStatus);
  }
}
