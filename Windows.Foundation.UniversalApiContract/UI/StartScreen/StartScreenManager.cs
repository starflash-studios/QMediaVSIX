// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.StartScreenManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.StartScreen
{
  /// <summary>Represents a Start screen manager object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IStartScreenManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class StartScreenManager : IStartScreenManager, IStartScreenManager2
  {
    /// <summary>Gets the user associated with the current Start screen.</summary>
    /// <returns>
    /// </returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Checks if the app can be pinned to the current Start screen.</summary>
    /// <param name="appListEntry">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern bool SupportsAppListEntry(AppListEntry appListEntry);

    /// <summary>Checks if the app is currently pinned to the Start screen.</summary>
    /// <param name="appListEntry">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ContainsAppListEntryAsync(
      AppListEntry appListEntry);

    /// <summary>Requests to pin the app to the current Start screen. Depending on the device family, this must be called on the UI thread, and will display a dialog asking the user to confirm they would like to pin the app.</summary>
    /// <param name="appListEntry">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestAddAppListEntryAsync(
      AppListEntry appListEntry);

    /// <summary>Checks if the specified secondary tile is pinned to Start.</summary>
    /// <param name="tileId">The TileId of the SecondaryTile that you want to check is pinned.</param>
    /// <returns>A boolean representing whether the specified secondary tile is pinned to Start.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ContainsSecondaryTileAsync(string tileId);

    /// <summary>Tries to remove the specified secondary tile from Start.</summary>
    /// <param name="tileId">The TileId of the SecondaryTile you want to remove.</param>
    /// <returns>A boolean representing whether the tile is not on Start. If removing wasn't allowed, this returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRemoveSecondaryTileAsync(string tileId);

    /// <summary>Gets the current Start screen manager.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern StartScreenManager GetDefault();

    /// <summary>Gets the Start screen manager for a specific user.</summary>
    /// <param name="user">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern StartScreenManager GetForUser(User user);
  }
}
