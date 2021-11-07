// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(546013965, 26453, 18636, 154, 179, 253, 3, 196, 99, 252, 146)]
  [ExclusiveTo(typeof (ChatMessageManager))]
  internal interface IChatMessageManagerStatics3 : IChatMessageManagerStatic
  {
    [RemoteAsync]
    IAsyncOperation<ChatSyncManager> RequestSyncManagerAsync();
  }
}
