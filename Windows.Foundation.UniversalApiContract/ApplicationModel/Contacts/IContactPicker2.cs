// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPicker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactPicker))]
  [Guid(3008369103, 23791, 19748, 170, 12, 52, 12, 82, 8, 114, 93)]
  internal interface IContactPicker2
  {
    IVector<ContactFieldType> DesiredFieldsWithContactFieldType { get; }

    IAsyncOperation<Contact> PickContactAsync();

    IAsyncOperation<IVector<Contact>> PickContactsAsync();
  }
}
