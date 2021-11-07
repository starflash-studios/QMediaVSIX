// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageBlocking
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides functionality for blocking messages.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IChatMessageBlockingStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ChatMessageBlocking
  {
    /// <summary>Asynchronously marks a message as blocked or unblocked.</summary>
    /// <param name="localChatMessageId">The ID of the message to block.</param>
    /// <param name="blocked">TRUE if the message should be blocked, FALSE if it should be unblocked.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction MarkMessageAsBlockedAsync(
      string localChatMessageId,
      bool blocked);
  }
}
