// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides methods for reading and accepting message change revisions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatMessageChangeReader : IChatMessageChangeReader
  {
    /// <summary>Accepts all the changes up to and including the latest change to the message.</summary>
    [MethodImpl]
    public extern void AcceptChanges();

    /// <summary>Accepts all the changes up to and including a specified change.</summary>
    /// <param name="lastChangeToAcknowledge">The last change to acknowledge.</param>
    [MethodImpl]
    public extern void AcceptChangesThrough(ChatMessageChange lastChangeToAcknowledge);

    /// <summary>Returns a batch list of chat message change objects from the message store’s change tracker.</summary>
    /// <returns>An asynchronous operation that returns a list of changes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ChatMessageChange>> ReadBatchAsync();
  }
}
