// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.ApplicationModel.UserDataTasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.UserDataAccounts
{
  /// <summary>Represents a user data account used to access email, contacts, calendars, and so on.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataAccount : 
    IUserDataAccount,
    IUserDataAccount2,
    IUserDataAccount3,
    IUserDataAccount4
  {
    /// <summary>Gets a string that uniquely identifies the UserDataAccount on the local device.</summary>
    /// <returns>A string that uniquely identifies the UserDataAccount on the local device.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets a user name associated with the UserDataAccount that is suitable for displaying.</summary>
    /// <returns>A user name associated with the UserDataAccount that is suitable for displaying.</returns>
    public extern string UserDisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether other apps on the device have read access to the UserDataAccount.</summary>
    /// <returns>Value indicating whether other apps on the device have read access to the UserDataAccount.</returns>
    public extern UserDataAccountOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the icon associated with the UserDataAccount.</summary>
    /// <returns>The icon associated with the UserDataAccount.</returns>
    public extern IRandomAccessStreamReference Icon { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the unique identifier for the type of the account.</summary>
    /// <returns>The unique identifier for the type of the account such as Exchange, Google, Pop/IMAP and so on.</returns>
    public extern string DeviceAccountTypeId { [MethodImpl] get; }

    /// <summary>Gets the unique identifier for the app package that created the UserDataAccount.</summary>
    /// <returns>The unique identifier for the app package that created the UserDataAccount.</returns>
    public extern string PackageFamilyName { [MethodImpl] get; }

    /// <summary>Asynchronously persists the UserDataAccount to the database.</summary>
    /// <returns>Async action that indicates completion of the save operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    /// <summary>Asynchronously deletes all the contact, calendar and email data associated with the account.</summary>
    /// <returns>An async action indicating success or failure.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Returns a collection of AppointmentCalendar instances associated with the UserDataAccount.</summary>
    /// <returns>A collection of AppointmentCalendar instances associated with the UserDataAccount.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    /// <summary>Returns a collection of EmailMailbox instances associated with the UserDataAccount.</summary>
    /// <returns>A collection of EmailMailbox instances associated with the UserDataAccount.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMailbox>> FindEmailMailboxesAsync();

    /// <summary>Returns a collection of ContactList instances associated with the UserDataAccount.</summary>
    /// <returns>A collection of ContactList instances associated with the UserDataAccount.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    /// <summary>Returns a collection of ContactAnnotationList instances associated with the UserDataAccount.</summary>
    /// <returns>A collection of ContactAnnotationList instances associated with the UserDataAccount.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotationList>> FindContactAnnotationListsAsync();

    /// <summary>Gets the enterprise identity associated with the user account.</summary>
    /// <returns>The enterprise identity associated with the user account.</returns>
    public extern string EnterpriseId { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the user account data is encrypted when the device becomes locked.</summary>
    /// <returns>A Boolean value indicating if the user account data is encrypted when the device becomes locked.</returns>
    public extern bool IsProtectedUnderLock { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of package family names for apps that have explicit read access even if they don't have the system capability.</summary>
    /// <returns>A list of package family names for apps that have explicit read access even if they don't have the system capability.</returns>
    public extern IVector<string> ExplictReadAccessPackageFamilyNames { [MethodImpl] get; }

    /// <summary>Gets or sets the human readable display name for the user data account.</summary>
    /// <returns>The human readable display name for the user data account.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This API supports the product infrastructure and is not intended to be used directly from your code.</summary>
    /// <returns>A ContactGroup.</returns>
    public extern bool CanShowCreateContactGroup { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides a place to store data to be used by the app when interacting with a UserDataAccount provider.</summary>
    /// <returns>Data to be used by the app when interacting with a UserDataAccount provider.</returns>
    public extern IPropertySet ProviderProperties { [MethodImpl] get; }

    /// <summary>Returns a collection of UserDataTask instances associated with the UserDataAccount.</summary>
    /// <returns>A collection of UserDataTask instances associated with the UserDataAccount.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserDataTaskList>> FindUserDataTaskListsAsync();

    /// <summary>This API supports the product infrastructure and is not intended to be used directly from your code.</summary>
    /// <returns>A collection of ContactGroup instances.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactGroup>> FindContactGroupsAsync();

    /// <summary>This API supports the product infrastructure and is not intended to be used directly from your code.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> TryShowCreateContactGroupAsync();
  }
}
