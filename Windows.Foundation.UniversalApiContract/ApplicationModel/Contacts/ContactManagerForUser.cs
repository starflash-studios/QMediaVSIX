// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a service that source apps can call to access contact data for a specific user.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactManagerForUser : IContactManagerForUser, IContactManagerForUser2
  {
    /// <summary>Asynchronously converts a Contact to a vCard.</summary>
    /// <param name="contact">The Contact to convert.</param>
    /// <returns>A stream containing the vCard data.</returns>
    [RemoteAsync]
    [Overload("ConvertContactToVCardAsync")]
    [MethodImpl]
    public extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact);

    /// <summary>Asynchronously converts a Contact to a vCard.</summary>
    /// <param name="contact">The Contact to convert.</param>
    /// <param name="maxBytes">The maximum size for the vCard in bytes.</param>
    /// <returns>A stream containing the vCard data.</returns>
    [Overload("ConvertContactToVCardAsyncWithMaxBytes")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact,
      uint maxBytes);

    /// <summary>Asynchronously converts a vCard to a Contact.</summary>
    /// <param name="vCard">A stream containing the vCard data.</param>
    /// <returns>The converted Contact.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> ConvertVCardToContactAsync(
      IRandomAccessStreamReference vCard);

    /// <summary>Asynchronously returns the ContactStore from the system.</summary>
    /// <param name="accessType">Specifies the access type, such as **AllContactsReadOnly** for all accounts or **AppContactsReadWrite** for the calling app's accounts.</param>
    /// <returns>Returns the ContactStore.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    /// <summary>Asynchronously returns the ContactAnnotationStore from the system.</summary>
    /// <param name="accessType">Specifies the access type, such as **AllAnnotationsReadWrite** for all annotations or **AppAnnotationsReadWrite** for the calling app's annotations.</param>
    /// <returns>Returns the ContactAnnotationStore.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    /// <summary>Gets or sets the display name order for contacts.</summary>
    /// <returns>The display name order for contacts.</returns>
    public extern ContactNameOrder SystemDisplayNameOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the sort order for contacts. For example, sort by last name or first name.</summary>
    /// <returns>The sort order.</returns>
    public extern ContactNameOrder SystemSortOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the User represented by this contact manager.</summary>
    /// <returns>The User represented by this contact manager.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Queries the operating system for a user’s contact and shows the contact data in a full contact card.</summary>
    /// <param name="contact">The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an Id, Emails, or a phone number from a Phones list to query the user’s contact database to retrieve a matching contact to display. Id has higher priority for querying. If an Id matches, the rest of query parameters will be ignored for matching purposes. If an Id does not find a match, the query uses the rest of query parameters.</param>
    /// <param name="fullContactCardOptions">Specifies how to display the full contact card.</param>
    [MethodImpl]
    public extern void ShowFullContactCard(
      Contact contact,
      FullContactCardOptions fullContactCardOptions);
  }
}
