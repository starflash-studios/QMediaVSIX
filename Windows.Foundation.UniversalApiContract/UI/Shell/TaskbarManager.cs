// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.TaskbarManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.StartScreen;

namespace Windows.UI.Shell
{
  /// <summary>Provides methods for pinning applications to the taskbar.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITaskbarManagerStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class TaskbarManager : ITaskbarManager, ITaskbarManager2
  {
    /// <summary>Gets whether the taskbar is present on the current device.</summary>
    /// <returns>A boolean indicating if the taskbar is present. This will return false on devices where no taskbar is present.</returns>
    public extern bool IsSupported { [MethodImpl] get; }

    /// <summary>Gets whether pinning to the taskbar is allowed.</summary>
    /// <returns>A boolean indicating whether pinning to the taskbar is allowed.</returns>
    public extern bool IsPinningAllowed { [MethodImpl] get; }

    /// <summary>Checks if the currently active application is already pinned to the taskbar.</summary>
    /// <returns>A boolean representing whether the current application is pinned to the taskbar.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsCurrentAppPinnedAsync();

    /// <summary>Checks if the specified application is already pinned to the taskbar.</summary>
    /// <param name="appListEntry">An AppListEntry corresponding to the application to check.</param>
    /// <returns>A boolean representing whether the specified application is pinned to the taskbar.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsAppListEntryPinnedAsync(
      AppListEntry appListEntry);

    /// <summary>Requests that the currently active application be pinned to the taskbar.</summary>
    /// <returns>A boolean representing whether the application was successfully pinned to the takbar. If the app was already pinned, this will immediately return true.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinCurrentAppAsync();

    /// <summary>Requests that the specified application be pinned to the taskbar.</summary>
    /// <param name="appListEntry">An AppListEntry corresponding to the application to pin to the taskbar.</param>
    /// <returns>A boolean representing whether the application was successfully pinned to the takbar. If the app was already pinned, this will immediately return true.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinAppListEntryAsync(
      AppListEntry appListEntry);

    /// <summary>Checks if the specified secondary tile is pinned to taskbar. Requires user approval as described here</summary>
    /// <param name="tileId">The TileId of the SecondaryTile that you want to check is pinned.</param>
    /// <returns>A boolean representing whether the specified secondary tile is pinned to taskbar.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsSecondaryTilePinnedAsync(string tileId);

    /// <summary>Requests to pin the specified tile to taskbar. Requires user approval as described here.</summary>
    /// <param name="secondaryTile">The secondary tile to be pinned.</param>
    /// <returns>A boolean representing whether the tile is pinned to the takbar. If the tile was already pinned, this will update the tile and return true. If pinning wasn't allowed or taskbar isn't supported, this will return false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinSecondaryTileAsync(
      SecondaryTile secondaryTile);

    /// <summary>Tries to unpin the secondary tile from taskbar. Requires user approval as described here</summary>
    /// <param name="tileId">The TileId of the SecondaryTile you want to unpin.</param>
    /// <returns>A boolean representing whether the tile is not pinned to taskbar. If unpinning wasn't allowed, this returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryUnpinSecondaryTileAsync(string tileId);

    /// <summary>Returns the TaskbarManager object active in the current process.</summary>
    /// <returns>The active TaskbarManager object.</returns>
    [MethodImpl]
    public static extern TaskbarManager GetDefault();
  }
}
