// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileFlyoutNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Provides the details of a tile flyout (mix view) notification. This includes the notification's XML content and, optionally, its expiration time. This class also provides a method by which you can retrieve the current flyout notification's XML content.</summary>
  [Activatable(typeof (ITileFlyoutNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TileFlyoutNotification : ITileFlyoutNotification
  {
    /// <summary>Creates a TileFlyoutNotification object for use in a tile flyout (mix view) notification. This object provides the XML content of the notification— the sub-tiles to be displayed and the text and image elements used in each sub-tile.</summary>
    /// <param name="content">The XML content of the tile flyout notification.</param>
    [MethodImpl]
    public extern TileFlyoutNotification(XmlDocument content);

    /// <summary>Gets the XML description of the current tile flyout (mix view) notification. This content can then be examined or manipulated as necessary.</summary>
    /// <returns>The XML content of the current tile flyout notification.</returns>
    public extern XmlDocument Content { [MethodImpl] get; }

    /// <summary>Gets or sets the time that the system will remove the tile flyout (mix view) notification. By default, a tile flyout notification does not expire. It is generally a best practice to explicitly set an expiration time to avoid stale content.</summary>
    /// <returns>The date and time that the notification should be removed.</returns>
    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }
  }
}
