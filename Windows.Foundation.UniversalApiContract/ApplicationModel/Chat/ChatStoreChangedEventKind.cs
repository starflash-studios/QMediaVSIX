// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatStoreChangedEventKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Specifies the type of change that occurred for a ChatMessageStoreChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatStoreChangedEventKind
  {
    /// <summary>Notifications have been missed</summary>
    NotificationsMissed,
    /// <summary>The chat store has been modified</summary>
    StoreModified,
    /// <summary>A chat message has been created</summary>
    MessageCreated,
    /// <summary>A chat message has been changed</summary>
    MessageModified,
    /// <summary>A chat message has been deleted</summary>
    MessageDeleted,
    /// <summary>A chat conversation has been modified</summary>
    ConversationModified,
    /// <summary>A chat conversation has been deleted</summary>
    ConversationDeleted,
    /// <summary>A chat conversation has been deleted of all messages from a transport.</summary>
    ConversationTransportDeleted,
  }
}
