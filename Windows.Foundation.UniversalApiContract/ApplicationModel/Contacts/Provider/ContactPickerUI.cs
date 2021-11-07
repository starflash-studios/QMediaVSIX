// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.ContactPickerUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  /// <summary>Allows you to call the contact picker UI so you can select one or more contacts.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactPickerUI : IContactPickerUI, IContactPickerUI2
  {
    /// <summary>Adds a Contact.</summary>
    /// <deprecated type="deprecate">AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.</deprecated>
    /// <param name="id">The ID for the contact.</param>
    /// <param name="contact">An object that contains the contact's information.</param>
    /// <returns>An AddContactResult -typed value that indicates whether the contact was added successfully.</returns>
    [Deprecated("AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AddContactResult AddContact(string id, Contact contact);

    /// <summary>Removes a contact.</summary>
    /// <param name="id">The ID of the contact to remove.</param>
    [MethodImpl]
    public extern void RemoveContact(string id);

    /// <summary>Checks to see whether the contact was already selected by the user.</summary>
    /// <param name="id">The ID of the contact.</param>
    /// <returns>True if the contact has already been selected; otherwise, false.</returns>
    [MethodImpl]
    public extern bool ContainsContact(string id);

    /// <summary>Specifies the fields that you want returned after the user selects one or more contacts.</summary>
    /// <returns>A collection of fields that you want returned. You can specify which fields you want through the KnownContactField class.</returns>
    public extern IVectorView<string> DesiredFields { [Deprecated("DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Determines the selection mode for the contact picker. The most common options are PickSingleContactAsync or PickMultipleContactsAsync.</summary>
    /// <returns>Specifies the selection mode that you want to use.</returns>
    public extern ContactSelectionMode SelectionMode { [MethodImpl] get; }

    /// <summary>Occurs when the user deselects or removes the contact.</summary>
    public extern event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved;

    /// <summary>Adds a Contact. </summary>
    /// <param name="contact">An object that contains the contact's information.</param>
    /// <returns>An AddContactResult -typed value that indicates whether the contact was added successfully.</returns>
    [MethodImpl]
    public extern AddContactResult AddContact(Contact contact);

    /// <summary>Gets the fields with contact field type that you want returned after the user selects one or more contacts.</summary>
    /// <returns>A collection of fields of contact field type that you want returned. The ContactFieldType values specify which fields you want.</returns>
    public extern IVector<ContactFieldType> DesiredFieldsWithContactFieldType { [MethodImpl] get; }
  }
}
