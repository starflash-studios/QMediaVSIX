// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageManagerStatic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4049363191, 54760, 24210, 85, 109, 224, 59, 96, 37, 49, 4)]
  [ExclusiveTo(typeof (ChatMessageManager))]
  internal interface IChatMessageManagerStatic
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ChatMessageTransport>> GetTransportsAsync();

    [RemoteAsync]
    IAsyncOperation<ChatMessageStore> RequestStoreAsync();

    IAsyncAction ShowComposeSmsMessageAsync(ChatMessage message);

    void ShowSmsSettings();
  }
}
