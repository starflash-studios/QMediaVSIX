// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  /// <summary>The type of push notification that has been received from the app server. Used by the NotificationType property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PushNotificationType
  {
    /// <summary>A push notification to display as toast.</summary>
    Toast,
    /// <summary>A push notification to update one or more elements of a tile.</summary>
    Tile,
    /// <summary>A push notification to update a tile's badge overlay.</summary>
    Badge,
    /// <summary>A push notification to perform an update to a tile that does not involve UI.</summary>
    Raw,
    /// <summary>A push notification to update an app's tile flyout.</summary>
    TileFlyout,
  }
}
