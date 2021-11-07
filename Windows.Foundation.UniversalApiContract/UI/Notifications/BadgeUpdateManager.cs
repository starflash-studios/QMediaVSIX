// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeUpdateManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  /// <summary>Creates BadgeUpdater objects that you use to manipulate a tile's badge overlay. This class also provides access to the XML content of the system-provided badge templates so that you can customize that content for use in updating your badges.</summary>
  [Static(typeof (IBadgeUpdateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBadgeUpdateManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public static class BadgeUpdateManager
  {
    /// <summary>Creates and initializes a new BadgeUpdateManagerForUser for the specified user, which lets you change the appearance or content of the badge on a tile for a specific user.</summary>
    /// <param name="user">The user who will receive the tile badge updates.</param>
    /// <returns>An object that will update tile badges for the specified user.</returns>
    [MethodImpl]
    public static extern BadgeUpdateManagerForUser GetForUser(User user);

    /// <summary>Creates and initializes a new instance of the BadgeUpdater, which lets you change the appearance or content of the badge on the calling app's tile.</summary>
    /// <returns>The object you will use to send changes to the app tile's badge.</returns>
    [Overload("CreateBadgeUpdaterForApplication")]
    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForApplication();

    /// <summary>Creates and initializes a new instance of the BadgeUpdater for a specified app tile's badge, usually the tile of another app in the package. The BadgeUpdater lets you change the appearance or content of that badge.</summary>
    /// <param name="applicationId">The unique ID of the tile whose badge you want to update.</param>
    /// <returns>The object you will use to send changes to the application tile's badge.</returns>
    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForApplication(
      string applicationId);

    /// <summary>Creates and initializes a new instance of the BadgeUpdater, which enables you to change the appearance or content of a badge on a secondary tile. The tile can belong to the calling app or any other app in the same package.</summary>
    /// <param name="tileId">The unique ID of the tile.</param>
    /// <returns>The object you will use to send badge updates to the tile identified by *tileID*.</returns>
    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    /// <summary>Gets the XML content of one of the predefined badge templates so that you can customize it for a badge update.</summary>
    /// <param name="type">The type of badge template, either a glyph or a number.</param>
    /// <returns>The object that contains the template XML.</returns>
    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(BadgeTemplateType type);
  }
}
