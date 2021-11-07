// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationHistoryChangedTriggerDetail2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(188148098, 51313, 18939, 186, 187, 37, 189, 188, 76, 196, 91)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ToastNotificationHistoryChangedTriggerDetail))]
  internal interface IToastNotificationHistoryChangedTriggerDetail2
  {
    string CollectionId { get; }
  }
}
