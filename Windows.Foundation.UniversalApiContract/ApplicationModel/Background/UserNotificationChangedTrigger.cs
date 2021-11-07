// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.UserNotificationChangedTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that fires when a UserNotification is added or removed.</summary>
  [Activatable(typeof (IUserNotificationChangedTriggerFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserNotificationChangedTrigger : IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of the **UserNotificationChangedTrigger** class.</summary>
    /// <param name="notificationKinds">The kind of notification trigger.</param>
    [MethodImpl]
    public extern UserNotificationChangedTrigger(NotificationKinds notificationKinds);
  }
}
