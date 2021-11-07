// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.UserNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents a notification for a specific user.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserNotification : IUserNotification
  {
    /// <summary>Gets the notification content.</summary>
    /// <returns>The notification content.</returns>
    public extern Notification Notification { [MethodImpl] get; }

    /// <summary>Gets info about the app that owns the notification.</summary>
    /// <returns>The app that owns the notification.</returns>
    public extern AppInfo AppInfo { [MethodImpl] get; }

    /// <summary>Gets the ID of the notification.</summary>
    /// <returns>The ID of the notification.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the time at which the notification was created.</summary>
    /// <returns>The time at which the notification was created.</returns>
    public extern DateTime CreationTime { [MethodImpl] get; }
  }
}
