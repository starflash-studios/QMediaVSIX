// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides access to message transports and the message store. Also provides a method to display the UI to compose messages.</summary>
  [Static(typeof (IChatMessageManager2Statics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IChatMessageManagerStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IChatMessageManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class ChatMessageManager
  {
    /// <summary>Gets the ChatSyncManager instance.</summary>
    /// <returns>When the asynchronous operation completes, a ChatSyncManager object is returned.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatSyncManager> RequestSyncManagerAsync();

    /// <summary>Asynchronously registers the app as a ChatMessageTransport in order to post messages to the ChatMessageStore.</summary>
    /// <returns>The transport ID for the newly registered ChatMessageTransport.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> RegisterTransportAsync();

    /// <summary>Asynchronously gets theChatMessageTransport.</summary>
    /// <param name="transportId">The locally unique identifier for the message transport.</param>
    /// <returns>The message transport.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatMessageTransport> GetTransportAsync(
      string transportId);

    /// <summary>Asynchronously gets the chat message transports available on the device.</summary>
    /// <returns>An asynchronous operation that returns a list of transports on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ChatMessageTransport>> GetTransportsAsync();

    /// <summary>Returns the SMS messaging store for the phone.</summary>
    /// <returns>An asynchronous operation that returns a ChatMessageStore on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatMessageStore> RequestStoreAsync();

    /// <summary>Shows the compose SMS dialog, pre-populated with data from the supplied ChatMessage object, allowing the user to send an SMS message.</summary>
    /// <param name="message">The chat message.</param>
    /// <returns>An asynchronous action.</returns>
    [MethodImpl]
    public static extern IAsyncAction ShowComposeSmsMessageAsync(ChatMessage message);

    /// <summary>Launches the device's SMS settings app.</summary>
    [MethodImpl]
    public static extern void ShowSmsSettings();
  }
}
