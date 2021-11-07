// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUILaunchActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Provides event information when an app is launched.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUILaunchActivatedEventArgs : 
    ILaunchActivatedEventArgs,
    IActivatedEventArgs,
    IPrelaunchActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser,
    ILaunchActivatedEventArgs2
  {
    /// <summary>Gets the arguments that are passed to the app during its launch activation.</summary>
    /// <returns>The list of arguments.</returns>
    public extern string Arguments { [MethodImpl] get; }

    /// <summary>Gets the ID of the source that was invoked to launch the application.</summary>
    /// <returns>The ID of the tile.</returns>
    public extern string TileId { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before this activation.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets an indication about whether a pre-launch has been activated.</summary>
    /// <returns>Indicates whether a pre-launch has been activated. **TRUE** indicates activated; otherwise, **FALSE**.</returns>
    public extern bool PrelaunchActivated { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Gets the app activated operation.</summary>
    /// <returns>The activation operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets additional information that is provided when the user launches your app from a tile. This will be **null** if the app is not launched from its tile or if the app is launched on a platform that doesn't support this property.</summary>
    /// <returns>Information about the tile that launched the app.</returns>
    public extern TileActivatedInfo TileActivatedInfo { [MethodImpl] get; }
  }
}
