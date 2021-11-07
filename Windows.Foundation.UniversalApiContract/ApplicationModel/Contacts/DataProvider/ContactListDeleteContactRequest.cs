// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.ContactListDeleteContactRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  /// <summary>Details of a request to delete a contact.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactListDeleteContactRequest : IContactListDeleteContactRequest
  {
    /// <summary>Gets the ID of the contact list that contains the contact that is to be deleted.</summary>
    /// <returns>The contact list that contains the contact that is to be deleted.</returns>
    public extern string ContactListId { [MethodImpl] get; }

    /// <summary>Gets the contact ID of the contact to be deleted.</summary>
    /// <returns>The contact ID of the contact to be deleted.</returns>
    public extern string ContactId { [MethodImpl] get; }

    /// <summary>Informs the client app that the request was processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
