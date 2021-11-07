// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (TileUpdater))]
  [Guid(155362443, 7569, 17644, 146, 67, 193, 232, 33, 194, 154, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITileUpdater
  {
    void Update(TileNotification notification);

    void Clear();

    void EnableNotificationQueue(bool enable);

    NotificationSetting Setting { get; }

    void AddToSchedule(ScheduledTileNotification scheduledTile);

    void RemoveFromSchedule(ScheduledTileNotification scheduledTile);

    IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();

    [Overload("StartPeriodicUpdate")]
    void StartPeriodicUpdate(Uri tileContent, PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    void StartPeriodicUpdate(
      Uri tileContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    void StopPeriodicUpdate();

    [Overload("StartPeriodicUpdateBatch")]
    void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateBatchAtTime")]
    void StartPeriodicUpdateBatch(
      IIterable<Uri> tileContents,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);
  }
}
