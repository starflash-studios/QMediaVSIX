// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallHistoryStore))]
  [Guid(797998520, 46094, 16939, 133, 69, 203, 25, 16, 166, 28, 82)]
  internal interface IPhoneCallHistoryStore
  {
    [RemoteAsync]
    IAsyncOperation<PhoneCallHistoryEntry> GetEntryAsync(
      string callHistoryEntryId);

    [Overload("GetEntryReader")]
    PhoneCallHistoryEntryReader GetEntryReader();

    [Overload("GetEntryReaderWithOptions")]
    PhoneCallHistoryEntryReader GetEntryReader(
      PhoneCallHistoryEntryQueryOptions queryOptions);

    IAsyncAction SaveEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    IAsyncAction DeleteEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    IAsyncAction DeleteEntriesAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    IAsyncAction MarkEntryAsSeenAsync(PhoneCallHistoryEntry callHistoryEntry);

    IAsyncAction MarkEntriesAsSeenAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    [RemoteAsync]
    IAsyncOperation<uint> GetUnseenCountAsync();

    [RemoteAsync]
    IAsyncAction MarkAllAsSeenAsync();

    IAsyncOperation<uint> GetSourcesUnseenCountAsync(IIterable<string> sourceIds);

    IAsyncAction MarkSourcesAsSeenAsync(IIterable<string> sourceIds);
  }
}
