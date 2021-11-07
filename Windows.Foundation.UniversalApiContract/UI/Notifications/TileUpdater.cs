// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Changes the content of the specific tile that the updater is bound to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TileUpdater : ITileUpdater, ITileUpdater2
  {
    /// <summary>Applies a change in content or appearance to the tile.</summary>
    /// <param name="notification">The object that supplies the new XML definition for the tile's content.</param>
    [MethodImpl]
    public extern void Update(TileNotification notification);

    /// <summary>Removes all updates and causes the tile to display its default content as declared in the app's manifest.</summary>
    [MethodImpl]
    public extern void Clear();

    /// <summary>Enables the tile to queue up to five notifications. This enables the notification queue on all tile sizes.</summary>
    /// <param name="enable">**True** to enable queuing; otherwise **false**.</param>
    [MethodImpl]
    public extern void EnableNotificationQueue(bool enable);

    /// <summary>Gets a value that specifies whether a tile can be updated through notifications.</summary>
    /// <returns>A value that indicates either that the tile can be updated through notifications, or who disabled them: developer, user, or administrator.</returns>
    public extern NotificationSetting Setting { [MethodImpl] get; }

    /// <summary>Adds a ScheduledTileNotification to the schedule.</summary>
    /// <param name="scheduledTile">The scheduled tile update object.</param>
    [MethodImpl]
    public extern void AddToSchedule(ScheduledTileNotification scheduledTile);

    /// <summary>Removes an upcoming tile update from the schedule.</summary>
    /// <param name="scheduledTile">The notification to remove from the schedule.</param>
    [MethodImpl]
    public extern void RemoveFromSchedule(ScheduledTileNotification scheduledTile);

    /// <summary>Retrieves a list of scheduled updates to the tile.</summary>
    /// <returns>The collection of scheduled updates for this tile.</returns>
    [MethodImpl]
    public extern IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();

    [Overload("StartPeriodicUpdate")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri tileContent,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri tileContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    /// <summary>Cancels the current series of timed updates for the tile that the updater is bound to.</summary>
    [MethodImpl]
    public extern void StopPeriodicUpdate();

    [Overload("StartPeriodicUpdateBatch")]
    [MethodImpl]
    public extern void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateBatchAtTime")]
    [MethodImpl]
    public extern void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    /// <summary>Enables the tile to queue up to five notifications on the medium tile.</summary>
    /// <param name="enable">**True** to enable queuing on this tile size; otherwise **false**.</param>
    [MethodImpl]
    public extern void EnableNotificationQueueForSquare150x150(bool enable);

    /// <summary>Enables the tile to queue up to five notifications on the wide tile.</summary>
    /// <param name="enable">**True** to enable queuing on this tile size; otherwise **false**.</param>
    [MethodImpl]
    public extern void EnableNotificationQueueForWide310x150(bool enable);

    /// <summary>Enables the tile to queue up to five notifications on the large tile.</summary>
    /// <param name="enable">**True** to enable queuing on this tile size; otherwise **false**.</param>
    [MethodImpl]
    public extern void EnableNotificationQueueForSquare310x310(bool enable);
  }
}
