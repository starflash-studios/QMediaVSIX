// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationHistory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotificationHistory))]
  [Guid(1002689107, 12081, 16530, 145, 41, 138, 213, 171, 240, 103, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotificationHistory2
  {
    [Overload("GetHistory")]
    IVectorView<ToastNotification> GetHistory();

    [Overload("GetHistoryWithId")]
    IVectorView<ToastNotification> GetHistory(string applicationId);
  }
}
