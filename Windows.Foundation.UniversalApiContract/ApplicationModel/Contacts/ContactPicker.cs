// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Controls how the Contact Picker user interface opens and what information it shows.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IContactPickerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContactPicker : IContactPicker, IContactPicker2, IContactPicker3
  {
    /// <summary>Creates a new instance of the ContactPicker class.</summary>
    [MethodImpl]
    public extern ContactPicker();

    /// <summary>Sets the text for the confirmation button in the Contact Picker user interface.</summary>
    /// <returns>The text of the button.</returns>
    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Controls whether the Contact Picker shows contacts as a complete entity or as a collection of fields.</summary>
    /// <returns>The mode for the Contact Picker user interface. You can set this to **Contacts** or **Fields**.</returns>
    public extern ContactSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sets the contact fields your app is interested in.</summary>
    /// <returns>An array of strings that represent the field names your app is interested in.</returns>
    public extern IVector<string> DesiredFields { [MethodImpl] get; }

    /// <summary>Launches the Contact Picker for selecting a single contact.</summary>
    /// <returns>The operation that launches the Contact Picker.</returns>
    [MethodImpl]
    public extern IAsyncOperation<ContactInformation> PickSingleContactAsync();

    /// <summary>Launches the Contact Picker for selecting multiple contacts.</summary>
    /// <returns>The operation that launches the contact picker.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();

    /// <summary>Gets the ways to connect with a contact.</summary>
    /// <returns>An array of ContactFieldType -typed values for a contact.</returns>
    public extern IVector<ContactFieldType> DesiredFieldsWithContactFieldType { [MethodImpl] get; }

    /// <summary>Launches the Contact Picker to select a single contact.</summary>
    /// <returns>The operation that launches the Contact Picker.</returns>
    [MethodImpl]
    public extern IAsyncOperation<Contact> PickContactAsync();

    /// <summary>Launches the Contact Picker for selecting multiple contacts.</summary>
    /// <returns>The operation that launches the contact picker.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IVector<Contact>> PickContactsAsync();

    /// <summary>Gets the User associated with the ContactPicker.</summary>
    /// <returns>The User associated with the ContactPicker.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Creates a new ContactPicker for a specific User.</summary>
    /// <param name="user">The User for which you want to create the ContactPicker.</param>
    /// <returns>Returns a ContactPicker for the account specified by the *user* parameter.</returns>
    [MethodImpl]
    public static extern ContactPicker CreateForUser(User user);

    /// <summary>Gets a Boolean value indicating if the contact picker is supported on the current platform.</summary>
    /// <returns>A Boolean value indicating if the contact picker is supported on the current platform.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsSupportedAsync();
  }
}
