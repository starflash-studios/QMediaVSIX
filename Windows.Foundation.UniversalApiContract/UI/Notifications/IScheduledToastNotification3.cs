// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotification3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2554502795, 48434, 19003, 157, 21, 34, 174, 164, 148, 98, 161)]
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  internal interface IScheduledToastNotification3
  {
    NotificationMirroring NotificationMirroring { get; set; }

    string RemoteId { get; set; }
  }
}
