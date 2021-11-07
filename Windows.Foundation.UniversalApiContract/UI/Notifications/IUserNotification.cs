// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IUserNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (UserNotification))]
  [Guid(2918704431, 20051, 17109, 156, 51, 235, 94, 165, 21, 178, 62)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserNotification
  {
    Notification Notification { get; }

    AppInfo AppInfo { get; }

    uint Id { get; }

    DateTime CreationTime { get; }
  }
}
