// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversationThreadingInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatConversationThreadingInfo))]
  [Guid(857481692, 31239, 17442, 163, 44, 36, 190, 124, 109, 171, 36)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatConversationThreadingInfo
  {
    string ContactId { get; set; }

    string Custom { get; set; }

    string ConversationId { get; set; }

    IVector<string> Participants { get; }

    ChatConversationThreadingKind Kind { get; set; }
  }
}
