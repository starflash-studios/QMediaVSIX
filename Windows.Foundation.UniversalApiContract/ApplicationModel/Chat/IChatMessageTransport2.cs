// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageTransport2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageTransport))]
  [Guid(2426885666, 55370, 19490, 169, 77, 84, 68, 68, 237, 200, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageTransport2 : IChatMessageTransport
  {
    ChatMessageTransportConfiguration Configuration { get; }

    ChatMessageTransportKind TransportKind { get; }
  }
}
