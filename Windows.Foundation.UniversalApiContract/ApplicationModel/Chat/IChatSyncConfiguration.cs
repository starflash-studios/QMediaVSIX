// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatSyncConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatSyncConfiguration))]
  [Guid(167274930, 27124, 19199, 130, 182, 6, 153, 47, 244, 2, 210)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IChatSyncConfiguration
  {
    bool IsSyncEnabled { get; set; }

    ChatRestoreHistorySpan RestoreHistorySpan { get; set; }
  }
}
