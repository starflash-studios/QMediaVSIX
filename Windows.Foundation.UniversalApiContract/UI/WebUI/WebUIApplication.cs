// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIApplication
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Enables an app to receive notifications related to the lifetime of the app.</summary>
  [Static(typeof (IWebUIActivationStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (IWebUIActivationStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebUIActivationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebUIActivationStatics4), 458752, "Windows.Foundation.UniversalApiContract")]
  public static class WebUIApplication
  {
    /// <summary>Occurs when the system creates a new view for the app.</summary>
    public static extern event EventHandler<NewWebUIViewCreatedEventArgs> NewWebUIViewCreated;

    /// <summary>Invoked when the application is activated in the background.</summary>
    public static extern event BackgroundActivatedEventHandler BackgroundActivated;

    /// <summary>Attempts to programatically restart the application.</summary>
    /// <param name="launchArguments">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AppRestartFailureReason> RequestRestartAsync(
      string launchArguments);

    /// <summary>Requests that the system restarts the app in the context of a specific user.</summary>
    /// <param name="user">The target user. The app will be restarted in the context of this user.</param>
    /// <param name="launchArguments">Launch arguments to pass to the app when it restarts.</param>
    /// <returns>An asynchronous operation that returns an AppRestartFailureReason object when it completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AppRestartFailureReason> RequestRestartForUserAsync(
      User user,
      string launchArguments);

    /// <summary>Occurs when the app is about to leave the background and before the app's UI is shown.</summary>
    public static extern event LeavingBackgroundEventHandler LeavingBackground;

    /// <summary>Occurs when the app has begins running in the background (no UI is shown for the app).</summary>
    public static extern event EnteredBackgroundEventHandler EnteredBackground;

    /// <summary>Specifies whether pre-launching is enabled.</summary>
    /// <param name="value">**true** to enable pre-launching; otherwise, **false**.</param>
    [MethodImpl]
    public static extern void EnablePrelaunch(bool value);

    /// <summary>Occurs when the app is activated.</summary>
    public static extern event ActivatedEventHandler Activated;

    /// <summary>Occurs when the app is suspending.</summary>
    public static extern event SuspendingEventHandler Suspending;

    /// <summary>Occurs when the app is resuming.</summary>
    public static extern event ResumingEventHandler Resuming;

    /// <summary>Occurs when the app is navigating.</summary>
    public static extern event NavigatedEventHandler Navigated;
  }
}
