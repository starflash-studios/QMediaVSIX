// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeUpdateManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  /// <summary>Creates BadgeUpdater objects that you use to manipulate a tile's badge overlay for a specific user. This class also provides access to the XML content of the system-provided badge templates so that you can customize that content for use in updating your badges.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class BadgeUpdateManagerForUser : IBadgeUpdateManagerForUser
  {
    /// <summary>Creates and initializes a new instance of the BadgeUpdater, which lets you change the appearance or content of the badge for the bound user on the calling app's tile.</summary>
    /// <returns>A BadgeUpdater for the current app and user.</returns>
    [Overload("CreateBadgeUpdaterForApplication")]
    [MethodImpl]
    public extern BadgeUpdater CreateBadgeUpdaterForApplication();

    /// <summary>Creates a new BadgeUpdater for the bound user and the specified app tile's badge, usually the tile of another app in the package. The BadgeUpdater lets you change the appearance or content of that badge.</summary>
    /// <param name="applicationId">The ID of the app that owns the tile to update.</param>
    /// <returns>A BadgeUpdater for the current user and the specified app.</returns>
    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    [MethodImpl]
    public extern BadgeUpdater CreateBadgeUpdaterForApplication(string applicationId);

    /// <summary>Creates a BadgeUpdater, which enables you to change the appearance or content of a badge on a secondary tile for the bound user. The tile can belong to the calling app or any other app in the same package.</summary>
    /// <param name="tileId">The ID of the secondary tile.</param>
    /// <returns>A BadgeUpdater for the secondary tile of the current app for the current user.</returns>
    [MethodImpl]
    public extern BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    /// <summary>Gets the user targeted by the badge update manager.</summary>
    /// <returns>The user targeted by the badge update manager.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
