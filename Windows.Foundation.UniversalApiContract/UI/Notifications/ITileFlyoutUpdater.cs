// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileFlyoutUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2369832810, 50277, 16466, 167, 64, 92, 38, 84, 193, 160, 137)]
  [ExclusiveTo(typeof (TileFlyoutUpdater))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITileFlyoutUpdater
  {
    void Update(TileFlyoutNotification notification);

    void Clear();

    [Overload("StartPeriodicUpdate")]
    void StartPeriodicUpdate(Uri tileFlyoutContent, PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    void StartPeriodicUpdate(
      Uri tileFlyoutContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    void StopPeriodicUpdate();

    NotificationSetting Setting { get; }
  }
}
