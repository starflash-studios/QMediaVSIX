// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileFlyoutUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Used to send or clear a tile flyout (mix view) notification. This class also provides methods to start and stop [periodic](https://docs.microsoft.com/previous-versions/windows/apps/jj150587(v=win.10)) tile flyout notifications.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class TileFlyoutUpdater : ITileFlyoutUpdater
  {
    /// <summary>Sends a new tile flyout (mix view) notification to the primary or secondary tile associated with the updater.</summary>
    /// <param name="notification">The notification object that supplies the new content for the tile's flyout.</param>
    [MethodImpl]
    public extern void Update(TileFlyoutNotification notification);

    /// <summary>Removes the current tile flyout (mix view) notification. A tile flyout notification does not have a default expiration time, so unless one is set explicitly through TileFlyoutNotification.ExpirationTime, this method is the only way to remove the flyout.</summary>
    [MethodImpl]
    public extern void Clear();

    [Overload("StartPeriodicUpdate")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri tileFlyoutContent,
      PeriodicUpdateRecurrence requestedInterval);

    [Overload("StartPeriodicUpdateAtTime")]
    [MethodImpl]
    public extern void StartPeriodicUpdate(
      Uri tileFlyoutContent,
      DateTime startTime,
      PeriodicUpdateRecurrence requestedInterval);

    /// <summary>Cancels the current series of [periodic](https://docs.microsoft.com/previous-versions/windows/apps/jj150587(v=win.10)) tile flyout (mix view) notification updates for the primary or secondary tile associated with the updater.</summary>
    [MethodImpl]
    public extern void StopPeriodicUpdate();

    /// <summary>Gets a value that specifies whether a tile's flyout can be updated through notifications.</summary>
    /// <returns>This value always returns **Enabled**. Mix view cannot currently be disabled.</returns>
    public extern NotificationSetting Setting { [MethodImpl] get; }
  }
}
