// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListCreateOrUpdateContactRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3031384351, 51273, 18384, 177, 25, 145, 207, 96, 91, 47, 42)]
  [ExclusiveTo(typeof (ContactListCreateOrUpdateContactRequest))]
  internal interface IContactListCreateOrUpdateContactRequest
  {
    string ContactListId { get; }

    Contact Contact { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(Contact createdOrUpdatedContact);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
