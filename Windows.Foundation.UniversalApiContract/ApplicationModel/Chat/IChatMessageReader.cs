// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3068819662, 17545, 22265, 118, 170, 226, 4, 104, 37, 20, 207)]
  [ExclusiveTo(typeof (ChatMessageReader))]
  internal interface IChatMessageReader
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync();
  }
}
