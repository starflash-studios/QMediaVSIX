// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactListLimitedWriteOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(3784840154, 18955, 17592, 154, 31, 160, 243, 210, 24, 23, 95)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (ContactListLimitedWriteOperations))]
  internal interface IContactListLimitedWriteOperations
  {
    [RemoteAsync]
    IAsyncOperation<bool> TryCreateOrUpdateContactAsync(Contact contact);

    [RemoteAsync]
    IAsyncOperation<bool> TryDeleteContactAsync(string contactId);
  }
}
