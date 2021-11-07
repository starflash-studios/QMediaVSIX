// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageNotificationTriggerDetails2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatMessageNotificationTriggerDetails))]
  [Guid(1807033056, 43527, 20433, 148, 113, 119, 147, 79, 183, 94, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatMessageNotificationTriggerDetails2 : IChatMessageNotificationTriggerDetails
  {
    bool ShouldDisplayToast { get; }

    bool ShouldUpdateDetailText { get; }

    bool ShouldUpdateBadge { get; }

    bool ShouldUpdateActionCenter { get; }
  }
}
