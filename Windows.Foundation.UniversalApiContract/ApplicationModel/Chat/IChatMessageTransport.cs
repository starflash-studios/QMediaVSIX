// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageTransport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(1672076280, 59059, 23706, 95, 133, 212, 121, 37, 185, 189, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageTransport))]
  internal interface IChatMessageTransport
  {
    bool IsAppSetAsNotificationProvider { get; }

    bool IsActive { get; }

    string TransportFriendlyName { get; }

    string TransportId { get; }

    [RemoteAsync]
    IAsyncAction RequestSetAsNotificationProviderAsync();
  }
}
