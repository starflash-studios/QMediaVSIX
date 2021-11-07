// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Specifies the type of chat message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatMessageKind
  {
    /// <summary>A standard chat message</summary>
    Standard,
    /// <summary>A file transfer request</summary>
    FileTransferRequest,
    /// <summary>A non-SMS/MMS message written to the device by the app</summary>
    TransportCustom,
    /// <summary>A conversation the user joined</summary>
    JoinedConversation,
    /// <summary>A conversation the user left</summary>
    LeftConversation,
    /// <summary>A conversation that another user joined</summary>
    OtherParticipantJoinedConversation,
    /// <summary>A conversation that another user left</summary>
    OtherParticipantLeftConversation,
  }
}
