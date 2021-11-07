// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatConversationThreadingKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Specifies how a conversation is threaded.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatConversationThreadingKind
  {
    /// <summary>By participants</summary>
    Participants,
    /// <summary>By contact ID</summary>
    ContactId,
    /// <summary>By conversation ID</summary>
    ConversationId,
    /// <summary>Custom threading defined by the app</summary>
    Custom,
  }
}
