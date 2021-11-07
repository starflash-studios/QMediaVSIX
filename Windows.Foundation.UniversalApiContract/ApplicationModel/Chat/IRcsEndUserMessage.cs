// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsEndUserMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RcsEndUserMessage))]
  [Guid(3620578795, 52183, 20283, 133, 38, 181, 6, 222, 195, 92, 83)]
  internal interface IRcsEndUserMessage
  {
    string TransportId { get; }

    string Title { get; }

    string Text { get; }

    bool IsPinRequired { get; }

    IVectorView<RcsEndUserMessageAction> Actions { get; }

    [RemoteAsync]
    IAsyncAction SendResponseAsync(RcsEndUserMessageAction action);

    [RemoteAsync]
    IAsyncAction SendResponseWithPinAsync(RcsEndUserMessageAction action, string pin);
  }
}
