// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatSearchReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides functionality to search for chat messages in the ChatMessageStore.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatSearchReader : IChatSearchReader
  {
    /// <summary>Returns a batch of found items matching the search criteria.</summary>
    /// <returns>A list of items matching the search criteria.</returns>
    [RemoteAsync]
    [Overload("ReadBatchAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IChatItem>> ReadBatchAsync();

    /// <summary>Returns a batch of found items matching the search criteria.</summary>
    /// <param name="count">The maximum number of items to return.</param>
    /// <returns>A list of items matching the search criteria.</returns>
    [RemoteAsync]
    [Overload("ReadBatchWithCountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IChatItem>> ReadBatchAsync(
      int count);
  }
}
