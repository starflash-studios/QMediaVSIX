// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ScheduledToastNotificationShowingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Provides info when the system is in the process of showing a scheduled toast notification.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class ScheduledToastNotificationShowingEventArgs : 
    IScheduledToastNotificationShowingEventArgs
  {
    /// <summary>Gets or sets whether Windows should perform its default handling of the notification.</summary>
    /// <returns>Set to **false** to allow the system to perform its default handling (which is subject to user and system settings). Set to **true** to tell the system that your app has handled the notification and that it shouldn't perform default handling.  The default value is **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the scheduled toast notification being shown.</summary>
    /// <returns>The scheduled toast notification being shown.</returns>
    public extern ScheduledToastNotification ScheduledToastNotification { [MethodImpl] get; }

    /// <summary>Requests that the app delay showing the scheduled toast notification.</summary>
    /// <returns>An object you can use to manage the delayed scheduled toast notification.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
