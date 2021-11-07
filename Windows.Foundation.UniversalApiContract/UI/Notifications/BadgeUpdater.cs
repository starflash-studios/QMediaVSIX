// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Updates a badge overlay on the specific tile that the updater is bound to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BadgeUpdater : IBadgeUpdater
  {
    /// <summary>Applies a change to the badge's glyph or number.</summary>
    /// <param name="notification">The object that supplies the new XML definition for the badge.</param>
    [MethodImpl]
    public extern void Update(BadgeNotification notification);

    /// <summary>Removes the badge from the tile that the updater is bound to.</summary>
    [MethodImpl]
    public extern void Clear();

    [Overload("StartPeriodicUpdate")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri badgeContent,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri badgeContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    /// <summary>Cancels the current series of timed updates for the badge that the updater is bound to.</summary>
    [MethodImpl]
    public extern void StopPeriodicUpdate();
  }
}
