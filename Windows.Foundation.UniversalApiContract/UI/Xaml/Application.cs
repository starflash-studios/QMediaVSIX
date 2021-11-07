// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Application
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml
{
  /// <summary>Encapsulates the app and its available services.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IApplicationFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Application : 
    IApplication,
    IApplication2,
    IApplication3,
    IApplicationOverrides,
    IApplicationOverrides2
  {
    /// <summary>Initializes a new instance of the Application class.</summary>
    [MethodImpl]
    public extern Application();

    /// <summary>Gets a collection of application-scoped resources, such as styles, templates, and brushes.</summary>
    /// <returns>A ResourceDictionary object that contains zero or more application-scoped resources.</returns>
    public extern ResourceDictionary Resources { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that declares how the app behaves when run in a debug environment.</summary>
    /// <returns>An object that declares how the app behaves when run in a debug environment.</returns>
    public extern DebugSettings DebugSettings { [MethodImpl] get; }

    /// <summary>Gets or sets a value that determines the light-dark preference for the overall theme of an app.</summary>
    /// <returns>A value of the enumeration. The initial value is the default theme set by the user in Windows settings.</returns>
    public extern ApplicationTheme RequestedTheme { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when an exception can be handled by app code, as forwarded from a native-level Windows Runtime error. Apps can mark the occurrence as handled in event data.</summary>
    public extern event UnhandledExceptionEventHandler UnhandledException;

    /// <summary>Occurs when the application transitions to Suspended state from some other state.</summary>
    public extern event SuspendingEventHandler Suspending;

    /// <summary>Occurs when the application transitions from Suspended state to Running state.</summary>
    public extern event EventHandler<object> Resuming;

    /// <summary>Shuts down the app.</summary>
    [MethodImpl]
    public extern void Exit();

    /// <summary>Gets or sets the type of visual feedback that an app can use to indicate the UI element with focus.</summary>
    /// <returns>The type of visual feedback used to indicate the UI element with focus. The default value depends on the operating system.</returns>
    public extern FocusVisualKind FocusVisualKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a UWP app supports mouse mode, which emulates pointer interaction experiences with non-pointer input devices such as an Xbox gamepad or remote control. (All nested elements inherit this behavior.)</summary>
    /// <returns>The pointer emulation mode. The default is Auto (the default system experience for the input device).</returns>
    public extern ApplicationRequiresPointerMode RequiresPointerMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the app moves from the background to the foreground.</summary>
    public extern event LeavingBackgroundEventHandler LeavingBackground;

    /// <summary>Occurs when the app moves from the foreground to the background.</summary>
    public extern event EnteredBackgroundEventHandler EnteredBackground;

    /// <summary>Gets or sets a value that indicates whether the framework automatically adjusts visual properties when high contrast themes are enabled.</summary>
    /// <returns>A value of the enumeration that indicates whether the framework automatically adjusts visual properties when high contrast themes are enabled. The default is **Auto**.</returns>
    public extern ApplicationHighContrastAdjustment HighContrastAdjustment { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IApplicationOverrides.OnActivated(IActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnLaunched(LaunchActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnFileActivated(
      FileActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnSearchActivated(
      SearchActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnShareTargetActivated(
      ShareTargetActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnFileOpenPickerActivated(
      FileOpenPickerActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnFileSavePickerActivated(
      FileSavePickerActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnCachedFileUpdaterActivated(
      CachedFileUpdaterActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnWindowCreated(
      WindowCreatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides2.OnBackgroundActivated(
      BackgroundActivatedEventArgs args);

    /// <summary>Gets the Application object for the current application.</summary>
    /// <returns>The Application object for the current application.</returns>
    public static extern Application Current { [MethodImpl] get; }

    /// <summary>Provides the entry point and requests initialization of the application. Use the callback to instantiate the Application class.</summary>
    /// <param name="callback">The callback that should be invoked during the initialization sequence.</param>
    [MethodImpl]
    public static extern void Start(ApplicationInitializationCallback callback);

    [Overload("LoadComponent")]
    [MethodImpl]
    public static extern void LoadComponent(object component, Uri resourceLocator);

    [Overload("LoadComponentWithResourceLocation")]
    [MethodImpl]
    public static extern void LoadComponent(
      object component,
      Uri resourceLocator,
      ComponentResourceLocation componentResourceLocation);
  }
}
