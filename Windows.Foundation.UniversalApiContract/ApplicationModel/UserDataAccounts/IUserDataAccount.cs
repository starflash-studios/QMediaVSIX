// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Appointments;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserDataAccount))]
  [Guid(3116643966, 45896, 18704, 190, 148, 74, 212, 187, 166, 222, 167)]
  internal interface IUserDataAccount
  {
    string Id { get; }

    string UserDisplayName { get; set; }

    UserDataAccountOtherAppReadAccess OtherAppReadAccess { get; set; }

    IRandomAccessStreamReference Icon { get; }

    string DeviceAccountTypeId { get; }

    string PackageFamilyName { get; }

    [RemoteAsync]
    IAsyncAction SaveAsync();

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMailbox>> FindEmailMailboxesAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotationList>> FindContactAnnotationListsAsync();
  }
}
