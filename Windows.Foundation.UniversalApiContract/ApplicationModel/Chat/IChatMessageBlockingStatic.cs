// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageBlockingStatic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4139361152, 52714, 4580, 136, 48, 8, 0, 32, 12, 154, 102)]
  [ExclusiveTo(typeof (ChatMessageBlocking))]
  internal interface IChatMessageBlockingStatic
  {
    [RemoteAsync]
    IAsyncAction MarkMessageAsBlockedAsync(string localChatMessageId, bool blocked);
  }
}
