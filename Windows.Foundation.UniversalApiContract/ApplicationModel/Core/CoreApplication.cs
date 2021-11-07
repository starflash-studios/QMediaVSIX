// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.CoreApplication
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Enables apps to handle state changes, manage windows, and integrate with a variety of UI frameworks.</summary>
  [Static(typeof (ICoreApplication2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreApplication), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreApplication3), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreApplicationExit), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreImmersiveApplication), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreApplicationUseCount), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreImmersiveApplication3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreImmersiveApplication2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [Static(typeof (ICoreApplicationUnhandledError), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CoreApplication
  {
    /// <summary>Creates a new view for the app.</summary>
    /// <param name="viewSource">The view provider for the new view.</param>
    /// <returns>The view.</returns>
    [Overload("CreateNewViewWithViewSource")]
    [MethodImpl]
    public static extern CoreApplicationView CreateNewView(
      IFrameworkViewSource viewSource);

    /// <summary>Creates a new view for the app.</summary>
    /// <returns>The view.</returns>
    [Overload("CreateNewViewFromMainView")]
    [MethodImpl]
    public static extern CoreApplicationView CreateNewView();

    /// <summary>Occurs when there is an underlying error that is routed to the CoreApplication instance, as part of global error handling logic.</summary>
    public static extern event EventHandler<UnhandledErrorDetectedEventArgs> UnhandledErrorDetected;

    /// <summary>Increments the total count of running app instances that use this CoreApplication instance.</summary>
    [MethodImpl]
    public static extern void IncrementApplicationUseCount();

    /// <summary>Decrements the total count of running app instances that use this CoreApplication instance.</summary>
    [MethodImpl]
    public static extern void DecrementApplicationUseCount();

    /// <summary>Gets all views for the app.</summary>
    /// <returns>All of the app's views.</returns>
    public static extern IVectorView<CoreApplicationView> Views { [MethodImpl] get; }

    /// <summary>Creates a new view for the app.</summary>
    /// <param name="runtimeType">The class ID of the view provider for the new view. If this parameter is null, use the current view provider.</param>
    /// <param name="entryPoint">Additional info about the view, such as its class name in the app code.</param>
    /// <returns>The view.</returns>
    [DefaultOverload]
    [Overload("CreateNewView")]
    [MethodImpl]
    public static extern CoreApplicationView CreateNewView(
      string runtimeType,
      string entryPoint);

    /// <summary>Gets the main CoreApplicationView instance for all running apps that use this CoreApplication instance.</summary>
    /// <returns>The main view for this CoreApplication instance.</returns>
    public static extern CoreApplicationView MainView { [MethodImpl] get; }

    /// <summary>Shuts down the app.</summary>
    [MethodImpl]
    public static extern void Exit();

    /// <summary>Occurs when the app is shutting down.</summary>
    public static extern event EventHandler<object> Exiting;

    /// <summary>Restart the app.</summary>
    /// <param name="launchArguments">The arguments to pass to the restarted instance.</param>
    /// <returns>The status of the restart request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AppRestartFailureReason> RequestRestartAsync(
      string launchArguments);

    /// <summary>Restart the app in the context of a different user.</summary>
    /// <param name="user">The user to restart the app as.</param>
    /// <param name="launchArguments">The arguments to pass to the restarted instance.</param>
    /// <returns>The status of the restart request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AppRestartFailureReason> RequestRestartForUserAsync(
      User user,
      string launchArguments);

    /// <summary>Fired when your app is activated by a background trigger.</summary>
    public static extern event EventHandler<BackgroundActivatedEventArgs> BackgroundActivated;

    /// <summary>Fired just before application UI becomes visible.</summary>
    public static extern event EventHandler<LeavingBackgroundEventArgs> LeavingBackground;

    /// <summary>Fired when the app enters the running in the background state.</summary>
    public static extern event EventHandler<EnteredBackgroundEventArgs> EnteredBackground;

    /// <summary>Enable or disable the operating system's ability to prelaunch your app.</summary>
    /// <param name="value">**True** to enable prelaunch for your app; **false**, otherwise.</param>
    [MethodImpl]
    public static extern void EnablePrelaunch(bool value);

    /// <summary>Gets the package-relative app identifier for the process.</summary>
    /// <returns>The package-relative app identifier for the process.</returns>
    public static extern string Id { [MethodImpl] get; }

    /// <summary>Occurs when the app is suspending.</summary>
    public static extern event EventHandler<SuspendingEventArgs> Suspending;

    /// <summary>Occurs when an app is resuming.</summary>
    public static extern event EventHandler<object> Resuming;

    /// <summary>Gets a property set that the app and UI frameworks can use to store info while the process is running.</summary>
    /// <returns>The property set.</returns>
    public static extern IPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets the active view for the app.</summary>
    /// <returns>The active view.</returns>
    [MethodImpl]
    public static extern CoreApplicationView GetCurrentView();

    /// <summary>Runs an external view provider factory to obtain a view provider.</summary>
    /// <param name="viewSource">An implementation of a view provider factory.</param>
    [MethodImpl]
    public static extern void Run(IFrameworkViewSource viewSource);

    /// <summary>Runs an activatable type factory to obtain an external activatable type.</summary>
    /// <param name="activationFactoryCallback">An implementation of an activatable type factory.</param>
    [MethodImpl]
    public static extern void RunWithActivationFactories(
      IGetActivationFactory activationFactoryCallback);
  }
}
