// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>A collection of phone call history entries.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneCallHistoryStore : IPhoneCallHistoryStore
  {
    /// <summary>Gets an entry from the store based on the entry id.</summary>
    /// <param name="callHistoryEntryId">The PhoneCallHistoryEntryt.Id of the relevant entry.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PhoneCallHistoryEntry> GetEntryAsync(
      string callHistoryEntryId);

    /// <summary>Retrieves a default phone call history entry that reads all entries.</summary>
    /// <returns>A reader that can be used to go through the phone call log entries.</returns>
    [Overload("GetEntryReader")]
    [MethodImpl]
    public extern PhoneCallHistoryEntryReader GetEntryReader();

    /// <summary>Retrieves an entry reader based on provided filters.</summary>
    /// <param name="queryOptions">The options used to create a filtered entry reader.</param>
    /// <returns>A reader that can be used to go through the phone call log entries.</returns>
    [Overload("GetEntryReaderWithOptions")]
    [MethodImpl]
    public extern PhoneCallHistoryEntryReader GetEntryReader(
      PhoneCallHistoryEntryQueryOptions queryOptions);

    /// <summary>Saves an entry to the store.</summary>
    /// <param name="callHistoryEntry">The entry to save.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern IAsyncAction SaveEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    /// <summary>Delete an entry from the store.</summary>
    /// <param name="callHistoryEntry">The entry to delete.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern IAsyncAction DeleteEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    [MethodImpl]
    public extern IAsyncAction DeleteEntriesAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    /// <summary>Updates an entry to indicate it has been seen.</summary>
    /// <param name="callHistoryEntry">The entry to update.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern IAsyncAction MarkEntryAsSeenAsync(
      PhoneCallHistoryEntry callHistoryEntry);

    [MethodImpl]
    public extern IAsyncAction MarkEntriesAsSeenAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    /// <summary>Gets the number of unseen entries.</summary>
    /// <returns>The number of unseen entries.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetUnseenCountAsync();

    /// <summary>Update all the entries to indicate they have all been seen by the user.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkAllAsSeenAsync();

    [MethodImpl]
    public extern IAsyncOperation<uint> GetSourcesUnseenCountAsync(
      IIterable<string> sourceIds);

    [MethodImpl]
    public extern IAsyncAction MarkSourcesAsSeenAsync(IIterable<string> sourceIds);
  }
}
