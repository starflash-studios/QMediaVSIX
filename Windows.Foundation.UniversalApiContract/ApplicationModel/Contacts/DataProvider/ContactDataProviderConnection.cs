// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  /// <summary>Represents a connection to a data provider client.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactDataProviderConnection : 
    IContactDataProviderConnection,
    IContactDataProviderConnection2
  {
    /// <summary>Occurs when the contact data client has requested to sync a contact list with the server..</summary>
    public extern event TypedEventHandler<ContactDataProviderConnection, ContactListSyncManagerSyncRequestEventArgs> SyncRequested;

    /// <summary>Occurs when the contact data client has requested a batch of server-side search results.</summary>
    public extern event TypedEventHandler<ContactDataProviderConnection, ContactListServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    /// <summary>Call this method to indicate that all event handlers have been set and the data provider is ready to start handling requests.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Raised when the client app attempts to create or update a contact.</summary>
    public extern event TypedEventHandler<ContactDataProviderConnection, ContactListCreateOrUpdateContactRequestEventArgs> CreateOrUpdateContactRequested;

    /// <summary>Raised when the client app attempts to delete a contact.</summary>
    public extern event TypedEventHandler<ContactDataProviderConnection, ContactListDeleteContactRequestEventArgs> DeleteContactRequested;
  }
}
