// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageReader2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(2305046147, 25787, 18189, 157, 244, 13, 232, 190, 26, 5, 191)]
  [ExclusiveTo(typeof (ChatMessageReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageReader2
  {
    [Overload("ReadBatchWithCountAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatMessage>> ReadBatchAsync(
      int count);
  }
}
