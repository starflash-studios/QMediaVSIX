// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessage2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(2254865202, 21567, 18933, 172, 113, 108, 42, 252, 101, 101, 253)]
  [ExclusiveTo(typeof (ChatMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessage2 : IChatMessage3, IChatMessage
  {
    ulong EstimatedDownloadSize { get; set; }

    new string From { set; }

    bool IsAutoReply { get; set; }

    new bool IsForwardingDisabled { set; }

    bool IsReplyDisabled { get; }

    new bool IsIncoming { set; }

    new bool IsRead { set; }

    bool IsSeen { get; set; }

    bool IsSimMessage { get; }

    new DateTime LocalTimestamp { set; }

    ChatMessageKind MessageKind { get; set; }

    ChatMessageOperatorKind MessageOperatorKind { get; set; }

    new DateTime NetworkTimestamp { set; }

    bool IsReceivedDuringQuietHours { get; set; }

    new string RemoteId { set; }

    new ChatMessageStatus Status { set; }

    new string Subject { set; }

    bool ShouldSuppressNotification { get; set; }

    ChatConversationThreadingInfo ThreadingInfo { get; set; }

    IVector<ChatRecipientDeliveryInfo> RecipientsDeliveryInfos { get; }
  }
}
