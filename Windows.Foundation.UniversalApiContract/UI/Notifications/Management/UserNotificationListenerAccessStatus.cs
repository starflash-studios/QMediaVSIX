// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Management.UserNotificationListenerAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications.Management
{
  /// <summary>Specifies whether the user has given the UserNotificationListener access to notifications.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum UserNotificationListenerAccessStatus
  {
    /// <summary>The user has not yet allowed or denied access.</summary>
    Unspecified,
    /// <summary>The user granted access to the UserNotificationListener.</summary>
    Allowed,
    /// <summary>The user denied access to the UserNotificationListener.</summary>
    Denied,
  }
}
