// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageAttachmentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(542659234, 41814, 23409, 108, 169, 102, 201, 133, 183, 208, 213)]
  [ExclusiveTo(typeof (ChatMessageAttachment))]
  internal interface IChatMessageAttachmentFactory
  {
    ChatMessageAttachment CreateChatMessageAttachment(
      string mimeType,
      IRandomAccessStreamReference dataStreamReference);
  }
}
