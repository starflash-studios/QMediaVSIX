// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ScheduledTileNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Defines the visual content and timing for a single, non-recurring scheduled update to a tile.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IScheduledTileNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ScheduledTileNotification : IScheduledTileNotification
  {
    [MethodImpl]
    public extern ScheduledTileNotification(XmlDocument content, DateTime deliveryTime);

    /// <summary>Gets the XML description of the content of the scheduled tile update.</summary>
    /// <returns>The object that contains the notification content.</returns>
    public extern XmlDocument Content { [MethodImpl] get; }

    /// <summary>Gets the time at which the tile is scheduled to be updated.</summary>
    /// <returns>The date and time that the notification will be updated.</returns>
    public extern DateTime DeliveryTime { [MethodImpl] get; }

    /// <summary>Gets or sets the time after which the tile notification should no longer be shown. By default, a tile notification does not expire. It is a best practice to explicitly set an expiration time to avoid stale content.</summary>
    /// <returns>The time after which the tile update should no longer be shown.</returns>
    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a string that Windows can use to prevent duplicate notification content from appearing in the queue.</summary>
    /// <returns>A string of 16 characters or less (plus a terminating null character) that identifies the notification in the stack. While there is no set form for the string content, we recommend that it should relate to the content of the notification.</returns>
    public extern string Tag { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the unique ID that is used to identify the scheduled tile in the schedule.</summary>
    /// <returns>The notification's identifier. This string is limited to 16 characters.</returns>
    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
