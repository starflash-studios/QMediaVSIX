// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(1262028074, 4418, 20617, 118, 218, 242, 219, 61, 23, 205, 5)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessage))]
  internal interface IChatMessage
  {
    IVector<ChatMessageAttachment> Attachments { get; }

    string Body { get; set; }

    string From { get; }

    string Id { get; }

    bool IsForwardingDisabled { get; }

    bool IsIncoming { get; }

    bool IsRead { get; }

    DateTime LocalTimestamp { get; }

    DateTime NetworkTimestamp { get; }

    IVector<string> Recipients { get; }

    IMapView<string, ChatMessageStatus> RecipientSendStatuses { get; }

    ChatMessageStatus Status { get; }

    string Subject { get; }

    string TransportFriendlyName { get; }

    string TransportId { get; set; }
  }
}
