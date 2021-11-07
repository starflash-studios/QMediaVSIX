// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (Notification))]
  [Guid(276838398, 60278, 20354, 151, 188, 218, 7, 83, 10, 46, 32)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface INotification
  {
    IReference<DateTime> ExpirationTime { get; set; }

    NotificationVisual Visual { get; set; }
  }
}
