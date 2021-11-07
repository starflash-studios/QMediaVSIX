// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.BadgeNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Defines the content, associated metadata, and expiration time of an update to a tile's badge overlay. A badge can display a number from 1 to 99 or a [status glyph](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10)).</summary>
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IBadgeNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BadgeNotification : IBadgeNotification
  {
    /// <summary>Creates and initializes a new instance of the BadgeNotification.</summary>
    /// <param name="content">The XML content that defines the badge update.</param>
    [MethodImpl]
    public extern BadgeNotification(XmlDocument content);

    /// <summary>Gets the XML that defines the value or glyph used as the tile's badge.</summary>
    /// <returns>The object that contains the XML.</returns>
    public extern XmlDocument Content { [MethodImpl] get; }

    /// <summary>Gets or sets the time that Windows will remove the badge from the tile. By default, local badge notifications do not expire and push, periodic, and scheduled badge notifications expire after three days. It is a best practice to explicitly set an expiration time to avoid stale content.</summary>
    /// <returns>The date and time that the notification should be removed.</returns>
    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }
  }
}
