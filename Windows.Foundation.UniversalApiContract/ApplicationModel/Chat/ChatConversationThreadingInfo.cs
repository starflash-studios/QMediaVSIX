// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatConversationThreadingInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides threading info for a ChatConversation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatConversationThreadingInfo : IChatConversationThreadingInfo
  {
    /// <summary>Initializes a new instance of the ChatConversationThreadingInfo class.</summary>
    [MethodImpl]
    public extern ChatConversationThreadingInfo();

    /// <summary>Gets or sets the Contact.Id for the remote participant.</summary>
    /// <returns>The Contact.Id for the remote participant.</returns>
    public extern string ContactId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string where you can store your own custom threading info.</summary>
    /// <returns>A string where you can store your own custom threading info.</returns>
    public extern string Custom { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ID of the ChatConversation.</summary>
    /// <returns>The ID of the ChatConversation.</returns>
    public extern string ConversationId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of participants in the ChatConversation.</summary>
    /// <returns>The list of participants in the ChatConversation.</returns>
    public extern IVector<string> Participants { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the type of threading info, such as participant, contact ID, conversation ID, and so on.</summary>
    /// <returns>A value that indicates the type of threading info.</returns>
    public extern ChatConversationThreadingKind Kind { [MethodImpl] get; [MethodImpl] set; }
  }
}
