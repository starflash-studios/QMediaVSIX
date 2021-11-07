// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (RcsManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2099710661, 2749, 20273, 155, 153, 165, 158, 113, 167, 183, 49)]
  internal interface IRcsManagerStatics
  {
    RcsEndUserMessageManager GetEndUserMessageManager();

    [RemoteAsync]
    IAsyncOperation<IVectorView<RcsTransport>> GetTransportsAsync();

    [RemoteAsync]
    IAsyncOperation<RcsTransport> GetTransportAsync(string transportId);

    IAsyncAction LeaveConversationAsync(ChatConversation conversation);
  }
}
