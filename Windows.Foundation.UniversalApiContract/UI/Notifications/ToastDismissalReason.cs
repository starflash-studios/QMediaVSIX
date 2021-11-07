// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastDismissalReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the reason that a toast notification is no longer being shown. Used with ToastDismissedEventArgs.Reason.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ToastDismissalReason
  {
    /// <summary>The user dismissed the toast notification.</summary>
    UserCanceled,
    /// <summary>The app explicitly hid the toast notification by calling the ToastNotifier.hide method.</summary>
    ApplicationHidden,
    /// <summary>The toast notification had been shown for the maximum allowed time and was faded out. The maximum time to show a toast notification is 7 seconds except in the case of long-duration toasts, in which case it is 25 seconds.</summary>
    TimedOut,
  }
}
