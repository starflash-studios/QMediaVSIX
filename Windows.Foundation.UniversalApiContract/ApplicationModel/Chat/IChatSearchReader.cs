// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatSearchReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1181089353, 36896, 18258, 152, 13, 57, 97, 35, 37, 245, 137)]
  [ExclusiveTo(typeof (ChatSearchReader))]
  internal interface IChatSearchReader
  {
    [Overload("ReadBatchAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IChatItem>> ReadBatchAsync();

    [Overload("ReadBatchWithCountAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IChatItem>> ReadBatchAsync(
      int count);
  }
}
