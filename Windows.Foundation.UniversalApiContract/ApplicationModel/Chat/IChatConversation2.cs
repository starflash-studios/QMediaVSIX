// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (ChatConversation))]
  [Guid(167972049, 38970, 18346, 154, 144, 238, 72, 238, 153, 123, 89)]
  internal interface IChatConversation2
  {
    bool CanModifyParticipants { get; set; }
  }
}
