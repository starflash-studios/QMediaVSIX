// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(1139539539, 35246, 23582, 162, 121, 58, 236, 254, 155, 111, 84)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (ToastNotification))]
  internal interface IToastNotification6
  {
    bool ExpiresOnReboot { get; set; }
  }
}
