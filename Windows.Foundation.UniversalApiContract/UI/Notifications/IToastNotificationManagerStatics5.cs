// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotificationManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3606443369, 54285, 16508, 137, 137, 136, 202, 180, 44, 253, 20)]
  internal interface IToastNotificationManagerStatics5
  {
    ToastNotificationManagerForUser GetDefault();
  }
}
