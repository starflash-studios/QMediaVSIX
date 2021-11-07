// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (BadgeUpdater))]
  [Guid(3053068244, 30050, 20332, 191, 163, 27, 110, 210, 229, 127, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBadgeUpdater
  {
    void Update(BadgeNotification notification);

    void Clear();

    [Overload("StartPeriodicUpdate")]
    void StartPeriodicUpdate(Uri badgeContent, PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    void StartPeriodicUpdate(
      Uri badgeContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    void StopPeriodicUpdate();
  }
}
