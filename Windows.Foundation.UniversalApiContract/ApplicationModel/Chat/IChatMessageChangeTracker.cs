// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageChangeTracker))]
  [Guid(1622667366, 28832, 21028, 80, 140, 36, 46, 247, 193, 208, 111)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageChangeTracker
  {
    void Enable();

    ChatMessageChangeReader GetChangeReader();

    void Reset();
  }
}
