// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageStoreChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1707503532, 65164, 18132, 145, 25, 87, 184, 65, 3, 17, 213)]
  [ExclusiveTo(typeof (ChatMessageStoreChangedEventArgs))]
  internal interface IChatMessageStoreChangedEventArgs
  {
    string Id { get; }

    ChatStoreChangedEventKind Kind { get; }
  }
}
