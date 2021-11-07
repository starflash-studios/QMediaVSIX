// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.IContactPickerUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  [Guid(3805025126, 53094, 17348, 169, 106, 165, 161, 18, 219, 71, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactPickerUI))]
  internal interface IContactPickerUI
  {
    [Deprecated("AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    AddContactResult AddContact(string id, Contact contact);

    void RemoveContact(string id);

    bool ContainsContact(string id);

    IVectorView<string> DesiredFields { [Deprecated("DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    ContactSelectionMode SelectionMode { get; }

    event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved;
  }
}
