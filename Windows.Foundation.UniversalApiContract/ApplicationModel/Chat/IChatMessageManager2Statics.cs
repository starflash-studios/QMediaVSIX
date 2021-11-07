// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageManager2Statics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(491075855, 40783, 20021, 150, 78, 27, 156, 166, 26, 192, 68)]
  internal interface IChatMessageManager2Statics : IChatMessageManagerStatic
  {
    [RemoteAsync]
    IAsyncOperation<string> RegisterTransportAsync();

    [RemoteAsync]
    IAsyncOperation<ChatMessageTransport> GetTransportAsync(
      string transportId);
  }
}
