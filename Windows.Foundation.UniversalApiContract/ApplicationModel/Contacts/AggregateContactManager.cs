// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.AggregateContactManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides functionality for linking individual (raw) contacts across services together into a single aggregate contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AggregateContactManager : IAggregateContactManager, IAggregateContactManager2
  {
    /// <summary>Returns the list of individual (raw) contacts from the specified aggregate contact.</summary>
    /// <param name="contact">The aggregate contact from which to extract the list of raw contacts.</param>
    /// <returns>The list of individual (raw) contacts from the specified aggregate contact.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Contact>> FindRawContactsAsync(
      Contact contact);

    /// <summary>Asynchronously attempts to link contacts together to make an aggregate contact.</summary>
    /// <param name="primaryContact">The first contact to link.</param>
    /// <param name="secondaryContact">The second contact to link to the *primaryContact*.</param>
    /// <returns>The newly created aggregate contact.</returns>
    [MethodImpl]
    public extern IAsyncOperation<Contact> TryLinkContactsAsync(
      Contact primaryContact,
      Contact secondaryContact);

    /// <summary>Asynchronously unlinks a raw contact from the parent aggregate contact.</summary>
    /// <param name="contact">The raw contact to remove from the aggregate.</param>
    /// <returns>An async action that indicates the operation is complete.</returns>
    [MethodImpl]
    public extern IAsyncAction UnlinkRawContactAsync(Contact contact);

    /// <summary>Chooses which of the raw contacts provides the main display picture for the aggregate.</summary>
    /// <param name="aggregateContact">The aggregate contact on which to set the picture.</param>
    /// <param name="rawContact">The raw contact that provides the picture for the aggregate.</param>
    /// <returns>True if successful, otherwise false.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetPreferredSourceForPictureAsync(
      Contact aggregateContact,
      Contact rawContact);

    /// <summary>Sets the identifier that specifies the remote contacts to link together with the contact data on your device.</summary>
    /// <param name="contactListId">The remote contact list identifier.</param>
    /// <param name="remoteSourceId">The identifier for the remote service, for example, “EXCH” for exchange accounts.</param>
    /// <param name="accountId">The unique roaming identifier of the account for the network.</param>
    /// <returns>The IAsyncAction to await.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetRemoteIdentificationInformationAsync(
      string contactListId,
      string remoteSourceId,
      string accountId);
  }
}
