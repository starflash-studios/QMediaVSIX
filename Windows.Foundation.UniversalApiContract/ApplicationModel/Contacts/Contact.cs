// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Contact
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a contact.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Contact : IContact, IContact2, IContactName, IContact3
  {
    /// <summary>Creates a new instance of the Contact class.</summary>
    [MethodImpl]
    public extern Contact();

    /// <summary>Sets and gets the name of the contact.</summary>
    /// <returns>The name of the contact.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a thumbnail image that represents this contact.</summary>
    /// <returns>The thumbnail image for the contact.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sets the fields that contain information about a contact.</summary>
    /// <returns>An array of fields containing information about a contact.</returns>
    public extern IVector<IContactField> Fields { [MethodImpl] get; }

    /// <summary>Gets and sets the identifier for a contact. The maximum string length for the identifier is 256 characters.</summary>
    /// <returns>The identifier for a contact.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets notes for a contact. The maximum string length for notes is 4096 characters.</summary>
    /// <returns>A string that contains notes for a contact.</returns>
    public extern string Notes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets info about the phones for a contact.</summary>
    /// <returns>An array of items that describe the phones for a contact.</returns>
    public extern IVector<ContactPhone> Phones { [MethodImpl] get; }

    /// <summary>Gets the email addresses for a contact.</summary>
    /// <returns>An array of email addresses for a contact.</returns>
    public extern IVector<ContactEmail> Emails { [MethodImpl] get; }

    /// <summary>Gets the contact addresses for a contact.</summary>
    /// <returns>An array of contact addresses for a contact.</returns>
    public extern IVector<ContactAddress> Addresses { [MethodImpl] get; }

    /// <summary>Gets the connected service accounts for a contact.</summary>
    /// <returns>An array of connected service accounts for a contact.</returns>
    public extern IVector<ContactConnectedServiceAccount> ConnectedServiceAccounts { [MethodImpl] get; }

    /// <summary>Gets the important dates for a contact.</summary>
    /// <returns>An array of important dates for a contact.</returns>
    public extern IVector<ContactDate> ImportantDates { [MethodImpl] get; }

    /// <summary>Gets the data suppliers for a contact. The maximum string length for each data supplier is 50 characters.</summary>
    /// <returns>An array of data suppliers for a contact.</returns>
    public extern IVector<string> DataSuppliers { [MethodImpl] get; }

    /// <summary>Gets the job info items for a contact.</summary>
    /// <returns>An array of job info items for a contact.</returns>
    public extern IVector<ContactJobInfo> JobInfo { [MethodImpl] get; }

    /// <summary>Gets the significant others for a contact.</summary>
    /// <returns>An array of significant others for a contact.</returns>
    public extern IVector<ContactSignificantOther> SignificantOthers { [MethodImpl] get; }

    /// <summary>Gets the Web sites for a contact.</summary>
    /// <returns>An array of Web sites for a contact.</returns>
    public extern IVector<ContactWebsite> Websites { [MethodImpl] get; }

    /// <summary>Gets the property set object for the contact.</summary>
    /// <returns>The IPropertySet interface for the property set object for the contact.</returns>
    public extern IPropertySet ProviderProperties { [MethodImpl] get; }

    /// <summary>Gets and sets the first name for a contact. The maximum string length for the first name is 64 characters.</summary>
    /// <returns>The first name for a contact.</returns>
    public extern string FirstName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the last name for a contact. The maximum string length for the last name is 64 characters.</summary>
    /// <returns>The last name for a contact.</returns>
    public extern string LastName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the middle name for a contact. The maximum string length for the middle name is 64 characters.</summary>
    /// <returns>The middle name for a contact.</returns>
    public extern string MiddleName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the Yomi (phonetic Japanese equivalent) given name for a contact. The maximum string length for the Yomi given name is 120 characters.</summary>
    /// <returns>The Yomi given name for a contact.</returns>
    public extern string YomiGivenName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the Yomi (phonetic Japanese equivalent) family name for a contact. The maximum string length for the Yomi family name is 120 characters.</summary>
    /// <returns>The Yomi family name for a contact.</returns>
    public extern string YomiFamilyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the honorific suffix for the name for a contact. The maximum string length for the honorific suffix is 32 characters.</summary>
    /// <returns>The honorific suffix for the name for a contact.</returns>
    public extern string HonorificNameSuffix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the honorific prefix for the name for a contact. The maximum string length for the honorific prefix is 32 characters.</summary>
    /// <returns>The honorific prefix for the name for a contact.</returns>
    public extern string HonorificNamePrefix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the display name for a contact. </summary>
    /// <returns>The display name for a contact.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the Yomi (phonetic Japanese equivalent) display name for a contact.</summary>
    /// <returns>The Yomi display name for a contact.</returns>
    public extern string YomiDisplayName { [MethodImpl] get; }

    /// <summary>Gets a string that identifies the ContactList to which this contact is a member.</summary>
    /// <returns>A string that identifies the ContactList to which this contact is a member.</returns>
    public extern string ContactListId { [MethodImpl] get; }

    /// <summary>Gets or sets the last time the user updated their display picture.</summary>
    /// <returns>The last time the user updated their display picture.</returns>
    public extern DateTime DisplayPictureUserUpdateTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if this Contact represents the user logged into the device.</summary>
    /// <returns>Boolean value indicating if this Contact represents the user logged into the device.</returns>
    public extern bool IsMe { [MethodImpl] get; }

    /// <summary>If this is a raw contact that is part of an aggregate contact, then this property identifies the parent aggregate.</summary>
    /// <returns>String value that identifies the parent aggregate contact.</returns>
    public extern string AggregateId { [MethodImpl] get; }

    /// <summary>Gets or sets an ID that can be used by a service provider to access the Contact in their remote system.</summary>
    /// <returns>An ID that can be used by a service provider to access the Contact in their remote system.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or puts the path to the ringtone file for the Contact.</summary>
    /// <returns>The path to the ringtone file for the Contact.</returns>
    public extern string RingToneToken { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if the user manually set the picture for the Contact.</summary>
    /// <returns>True if the user manually set the picture, false if this is an aggregate contact and the picture was chosen from one of the raw child contacts.</returns>
    public extern bool IsDisplayPictureManuallySet { [MethodImpl] get; }

    /// <summary>Gets a large version of the display picture for the Contact.</summary>
    /// <returns>A large version of the display picture for the Contact.</returns>
    public extern IRandomAccessStreamReference LargeDisplayPicture { [MethodImpl] get; }

    /// <summary>Gets a small version of the display picture for the Contact.</summary>
    /// <returns>A small version of the display picture for the Contact.</returns>
    public extern IRandomAccessStreamReference SmallDisplayPicture { [MethodImpl] get; }

    /// <summary>Gets or sets the display picture for the Contact in its original size.</summary>
    /// <returns>The display picture for the Contact in its original size.</returns>
    public extern IRandomAccessStreamReference SourceDisplayPicture { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or puts the path to the audio file to play when an SMS/MMS message is received from the Contact.</summary>
    /// <returns>The path to the audio file to play when an SMS/MMS message is received from the Contact.</returns>
    public extern string TextToneToken { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating of this is an aggregate Contact.</summary>
    /// <returns>Boolean value indicating of this is an aggregate Contact.</returns>
    public extern bool IsAggregate { [MethodImpl] get; }

    /// <summary>Gets the full name of the Contact.</summary>
    /// <returns>The full name of the Contact.</returns>
    public extern string FullName { [MethodImpl] get; }

    /// <summary>Gets or sets the display that was manually entered by the user.</summary>
    /// <returns>The display that was manually entered by the user.</returns>
    public extern string DisplayNameOverride { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the nickname for the Contact.</summary>
    /// <returns>The nickname for the Contact.</returns>
    public extern string Nickname { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the name used to sort the contact.</summary>
    /// <returns>The name used to sort the contact.</returns>
    public extern string SortName { [MethodImpl] get; }
  }
}
