// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotationStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a data store that contains contact annotations.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactAnnotationStore : IContactAnnotationStore, IContactAnnotationStore2
  {
    /// <summary>Gets a list of Id values based on Contact objects with a specified email address.</summary>
    /// <param name="emailAddress">The email address used to find the contact Id values.</param>
    /// <returns>The list of Contact objects containing the specified *emailAddress*.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> FindContactIdsByEmailAsync(
      string emailAddress);

    /// <summary>Gets a list of Id values based on Contact objects with a specified phone number.</summary>
    /// <param name="phoneNumber">The phone number used to find the contact Id values.</param>
    /// <returns>The list of Contact objects containing the specified *phoneNumber*.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> FindContactIdsByPhoneNumberAsync(
      string phoneNumber);

    /// <summary>Get the annotations for the specified Contact.</summary>
    /// <param name="contact">The Contact for which to retrieve annotations.</param>
    /// <returns>The list of ContactAnnotation objects.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactAsync(
      Contact contact);

    /// <summary>Asynchronously disables the specified ContactAnnotation, usually as a result of user input.</summary>
    /// <param name="annotation">The annotation to disable.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [MethodImpl]
    public extern IAsyncAction DisableAnnotationAsync(ContactAnnotation annotation);

    /// <summary>Asynchronously creates a ContactAnnotationList.</summary>
    /// <returns>The newly created ContactAnnotationList.</returns>
    [RemoteAsync]
    [Overload("CreateAnnotationListAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync();

    /// <summary>Asynchronously creates a ContactAnnotationList and associates it with the specified user data account ID.</summary>
    /// <param name="userDataAccountId">The ID for the user data account with which to associate the new ContactAnnotationList. The user data account must be owned by this app.</param>
    /// <returns>The newly created ContactAnnotationList.</returns>
    [RemoteAsync]
    [Overload("CreateAnnotationListInAccountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync(
      string userDataAccountId);

    /// <summary>Asynchronously gets the ContactAnnotationList with the specified ID.</summary>
    /// <param name="annotationListId">The ID of the ContactAnnotationList to get.</param>
    /// <returns>The ContactAnnotationList with the ID specified in *annotationListId*.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationList> GetAnnotationListAsync(
      string annotationListId);

    /// <summary>Asynchronously gets the list of ContactAnnotationList objects for the app.</summary>
    /// <returns>The list of ContactAnnotationList objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotationList>> FindAnnotationListsAsync();

    /// <summary>Gets the annotations for the specified ContactList.</summary>
    /// <param name="contactListId">The ID of the ContactList for which to retrieve annotations.</param>
    /// <returns>The list of ContactAnnotation objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactListAsync(
      string contactListId);
  }
}
