// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactListLimitedWriteOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides operations that an app can perform on a contact list that it has not created.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactListLimitedWriteOperations : IContactListLimitedWriteOperations
  {
    /// <summary>Asynchronously attempts to create or update a contact.</summary>
    /// <param name="contact">The contact to create or update.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCreateOrUpdateContactAsync(Contact contact);

    /// <summary>Asynchronously attempts to delete a contact.</summary>
    /// <param name="contactId">The ID of the contact to delete.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDeleteContactAsync(string contactId);
  }
}
