// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotifier2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotifier))]
  [Guid(893618630, 31745, 19413, 156, 32, 96, 67, 64, 205, 43, 116)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IToastNotifier2
  {
    [Overload("UpdateWithTagAndGroup")]
    NotificationUpdateResult Update(
      NotificationData data,
      string tag,
      string group);

    [Overload("UpdateWithTag")]
    NotificationUpdateResult Update(NotificationData data, string tag);
  }
}
