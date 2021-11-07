// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides methods for reading messages from the message store.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageReader : IChatMessageReader, IChatMessageReader2
  {
    /// <summary>Returns a batch list of chat messages from the message store.</summary>
    /// <returns>An asynchronous operation that returns a list of chat messages upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync();

    /// <summary>Returns a batch list of chat messages from the message store limited to the specified size.</summary>
    /// <param name="count">The size of the batch to read.</param>
    /// <returns>An asynchronous operation that returns a list of chat messages upon successful completion.</returns>
    [Overload("ReadBatchWithCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync(
      int count);
  }
}
