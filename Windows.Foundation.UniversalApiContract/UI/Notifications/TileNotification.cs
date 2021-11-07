// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Defines an update to a tile, including its visuals, identification tag, and expiration time.</summary>
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ITileNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TileNotification : ITileNotification
  {
    /// <summary>Creates and initializes a new instance of the TileNotification object for use with a TileUpdater.</summary>
    /// <param name="content">The object that provides the content for the tile notification.</param>
    [MethodImpl]
    public extern TileNotification(XmlDocument content);

    /// <summary>Gets the XML description of the notification content, which you can then manipulate to alter the notification.</summary>
    /// <returns>The object that contains the notification content.</returns>
    public extern XmlDocument Content { [MethodImpl] get; }

    /// <summary>Gets or sets the time that Windows will remove the notification from the tile. By default, a tile update does not expire. It is a best practice to explicitly set an expiration time to avoid stale content.</summary>
    /// <returns>The date and time that the notification should be removed.</returns>
    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a string that Windows can use to prevent duplicate notification content from appearing in the queue.</summary>
    /// <returns>A string of 16 characters or less (plus a terminating null character) that identifies the notification in the stack. While there is no set form to the string content, we recommend that it should relate to the content of the notification.</returns>
    public extern string Tag { [MethodImpl] set; [MethodImpl] get; }
  }
}
