// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationSetting
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the limitations on tile or toast notification display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NotificationSetting
  {
    /// <summary>All notifications raised by this app can be displayed.</summary>
    Enabled,
    /// <summary>The user has disabled notifications for this app.</summary>
    DisabledForApplication,
    /// <summary>The user or administrator has disabled all notifications for this user on this computer.</summary>
    DisabledForUser,
    /// <summary>An administrator has disabled all notifications on this computer through group policy. The group policy setting overrides the user's setting.</summary>
    DisabledByGroupPolicy,
    /// <summary>This app has not declared itself toast capable in its package.appxmanifest file. This setting is found on the manifest's Application UI page, under the Notification section. For an app to send toast, the **Toast Capable** option must be set to "Yes".</summary>
    DisabledByManifest,
  }
}
