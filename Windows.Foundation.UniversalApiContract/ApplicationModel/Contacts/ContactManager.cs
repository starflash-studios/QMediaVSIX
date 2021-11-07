// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a service that source apps can call to access contact data.</summary>
  [Static(typeof (IContactManagerStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContactManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IContactManagerStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContactManagerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContactManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ContactManager
  {
    /// <summary>Gets a Boolean value indicating if the ShowFullContactCard method is supported on the current platform.</summary>
    /// <returns>An asynchronous operation that returns **true** if the ShowFullContactCard method is supported on the current platform.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsShowFullContactCardSupportedAsync();

    /// <summary>Gets or sets a Boolean that indicates whether the middle name of a contact is included in the DisplayName and SortName of a contact.</summary>
    /// <returns>A Boolean that indicates whether the middle name of a contact is included in the DisplayName and SortName of a contact.</returns>
    public static extern bool IncludeMiddleNameInSystemDisplayAndSort { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the ContactManagerForUser object for the specified user.</summary>
    /// <param name="user">The user account to use to get the ContactManagerForUser object.</param>
    /// <returns>Returns the contact manager for the account specified by the *user* parameter.</returns>
    [MethodImpl]
    public static extern ContactManagerForUser GetForUser(User user);

    /// <summary>Asynchronously converts a Contact to a vCard.</summary>
    /// <param name="contact">The Contact to convert.</param>
    /// <returns>A stream containing the vCard data.</returns>
    [Overload("ConvertContactToVCardAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact);

    /// <summary>Asynchronously converts a Contact to a vCard.</summary>
    /// <param name="contact">The Contact to convert.</param>
    /// <param name="maxBytes">The maximum size for the vCard in bytes.</param>
    /// <returns>A stream containing the vCard data.</returns>
    [Overload("ConvertContactToVCardAsyncWithMaxBytes")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact,
      uint maxBytes);

    /// <summary>Asynchronously converts a vCard to a Contact.</summary>
    /// <param name="vCard">A stream containing the vCard data.</param>
    /// <returns>The converted Contact.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Contact> ConvertVCardToContactAsync(
      IRandomAccessStreamReference vCard);

    /// <summary>Retrieves a ContactStore object that enables searching or retrieving contacts on the device.</summary>
    /// <param name="accessType">Specifies the type of read/write access requested.</param>
    /// <returns>An asynchronous operation that returns a ContactStore object on successful completion.</returns>
    [RemoteAsync]
    [Overload("RequestStoreAsyncWithAccessType")]
    [MethodImpl]
    public static extern IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    /// <summary>Asynchronously requests access to the ContactAnnotationStore.</summary>
    /// <param name="accessType">Specifies the type of access request, app contact annotations or all annotations.</param>
    /// <returns>The requested ContactAnnotationStore.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    /// <summary>Gets a Boolean value indicating if the ShowContactCard method is supported on the current platform.</summary>
    /// <returns>A Boolean value indicating if the ShowContactCard method is supported on the current platform.</returns>
    [MethodImpl]
    public static extern bool IsShowContactCardSupported();

    /// <summary>Shows a contact card with the specified parameters.</summary>
    /// <param name="contact">The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an Id, Emails, or a phone number from a Phones list to query the user’s contact database to retrieve a matching contact to display. Id has higher priority for querying. If an Id matches, the rest of query parameters will be ignored for matching purposes. If an Id does not find a match, the query uses the rest of query parameters.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the contact card, not within that rectangular area. For example, if an app uses a button to show the contact card, pass the Rect of the button so the contact card displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the contact card.</param>
    /// <param name="contactCardOptions">Specifies how to display the contact card, such as which tab to start on when displaying a mini contact card.</param>
    [Overload("ShowContactCardWithOptions")]
    [MethodImpl]
    public static extern void ShowContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    /// <summary>Gets a Boolean value indicating if the ShowDelayLoadedContactCard method is supported on the current platform.</summary>
    /// <returns>A Boolean value indicating if the ShowDelayLoadedContactCard method is supported on the current platform.</returns>
    [MethodImpl]
    public static extern bool IsShowDelayLoadedContactCardSupported();

    /// <summary>Shows a contact card that can be updated later if the contact does not exist in the user’s contact database.</summary>
    /// <param name="contact">The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an Id, Emails, or a phone number from a Phones list to query the user’s contact database to retrieve a matching contact to display. Id has higher priority for querying. If an Id matches, the rest of query parameters will be ignored for matching purposes. If an Id does not find a match, the query uses the rest of query parameters.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the contact card, not within that rectangular area. For example, if an app uses a button to show the contact card, pass the Rect of the button so the contact card displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the contact card.</param>
    /// <param name="contactCardOptions">Specifies how to display the contact card, such as which tab to start on if you are displaying a mini contact card, or what header type to use if you are showing a full contact card.</param>
    /// <returns>Returns the ContactCardDelayedDataLoader object that can be used to update the contact card.</returns>
    [Overload("ShowDelayLoadedContactCardWithOptions")]
    [MethodImpl]
    public static extern ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    /// <summary>Queries the operating system for a user’s contact and shows the contact data in a full contact card.</summary>
    /// <param name="contact">The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an Id, Emails, or a phone number from a Phones list to query the user’s contact database to retrieve a matching contact to display. Id has higher priority for querying. If an Id matches, the rest of query parameters will be ignored for matching purposes. If an Id does not find a match, the query uses the rest of query parameters.</param>
    /// <param name="fullContactCardOptions">Specifies how to display the full contact card.</param>
    [MethodImpl]
    public static extern void ShowFullContactCard(
      Contact contact,
      FullContactCardOptions fullContactCardOptions);

    /// <summary>Gets or puts the display name order.</summary>
    /// <returns>Specifies the display name order.</returns>
    public static extern ContactNameOrder SystemDisplayNameOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or puts the sort order.</summary>
    /// <returns>Specifies the sort order.</returns>
    public static extern ContactNameOrder SystemSortOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves a ContactStore object that enables searching or retrieving contacts on the device.</summary>
    /// <returns>An asynchronous operation that returns a ContactStore object on successful completion.</returns>
    [Overload("RequestStoreAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ContactStore> RequestStoreAsync();

    /// <summary>Queries the operating system for a user’s contact and shows the contact data in a contact card.</summary>
    /// <param name="contact">The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an Id, Emails, or a phone number from a Phones list to query the user’s contact database to retrieve a matching contact to display. Id has higher priority for querying. If an Id matches, the rest of query parameters will be ignored for matching purposes. If an Id does not find a match, the query uses the rest of query parameters.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the contact card, not within that rectangular area. For example, if an app uses a button to show the contact card, pass the Rect of the button so the contact card displays around the button, not overlapping it.</param>
    [Overload("ShowContactCard")]
    [MethodImpl]
    public static extern void ShowContactCard(Contact contact, Rect selection);

    /// <summary>Queries the operating system for a user’s contact and shows the contact data in a contact card.</summary>
    /// <param name="contact">The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an Id, Emails, or a phone number from a Phones list to query the user’s contact database to retrieve a matching contact to display. Id has higher priority for querying. If an Id matches, the rest of query parameters will be ignored for matching purposes. If an Id does not find a match, the query uses the rest of query parameters.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the contact card, not within that rectangular area. For example, if an app uses a button to show the contact card, pass the Rect of the button so the contact card displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the contact card.</param>
    [Overload("ShowContactCardWithPlacement")]
    [MethodImpl]
    public static extern void ShowContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement);

    /// <summary>Shows a contact card that can be updated later if the contact does not exist in the user’s contact database.</summary>
    /// <param name="contact">The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an Id, Emails, or a phone number from a Phones list to query the user’s contact database to retrieve a matching contact to display. Id has higher priority for querying. If an Id matches, the rest of query parameters will be ignored for matching purposes. If an Id does not find a match, the query uses the rest of query parameters.</param>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the contact card, not within that rectangular area. For example, if an app uses a button to show the contact card, pass the Rect of the button so the contact card displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The Placement that describes the preferred placement of the contact card.</param>
    /// <returns>Returns the ContactCardDelayedDataLoader object that can be used to update the contact card.</returns>
    [Overload("ShowDelayLoadedContactCard")]
    [MethodImpl]
    public static extern ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement);
  }
}
