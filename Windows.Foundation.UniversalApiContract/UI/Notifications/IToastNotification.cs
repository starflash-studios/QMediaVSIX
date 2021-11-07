// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastNotification))]
  [Guid(2575181429, 1438, 20064, 139, 6, 23, 96, 145, 124, 139, 128)]
  internal interface IToastNotification
  {
    XmlDocument Content { get; }

    IReference<DateTime> ExpirationTime { set; get; }

    event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed;

    event TypedEventHandler<ToastNotification, object> Activated;

    event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed;
  }
}
