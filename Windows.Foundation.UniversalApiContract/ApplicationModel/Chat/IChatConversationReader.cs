// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversationReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatConversationReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(89208530, 56882, 19015, 169, 58, 179, 220, 8, 51, 133, 43)]
  internal interface IChatConversationReader
  {
    [Overload("ReadBatchAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatConversation>> ReadBatchAsync();

    [RemoteAsync]
    [Overload("ReadBatchWithCountAsync")]
    IAsyncOperation<IVectorView<ChatConversation>> ReadBatchAsync(
      int count);
  }
}
