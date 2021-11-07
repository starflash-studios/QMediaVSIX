// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IUserNotificationChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3065866297, 31183, 19237, 130, 192, 12, 225, 238, 248, 31, 140)]
  [ExclusiveTo(typeof (UserNotificationChangedEventArgs))]
  internal interface IUserNotificationChangedEventArgs
  {
    UserNotificationChangedKind ChangeKind { get; }

    uint UserNotificationId { get; }
  }
}
