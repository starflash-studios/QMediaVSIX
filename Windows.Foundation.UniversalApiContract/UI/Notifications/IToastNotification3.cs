// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotification))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(837332696, 33089, 20377, 188, 10, 196, 237, 33, 41, 125, 119)]
  internal interface IToastNotification3
  {
    NotificationMirroring NotificationMirroring { get; set; }

    string RemoteId { get; set; }
  }
}
