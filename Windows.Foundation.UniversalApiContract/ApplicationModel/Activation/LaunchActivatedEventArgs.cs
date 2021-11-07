// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.LaunchActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides event information when an app is launched.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LaunchActivatedEventArgs : 
    ILaunchActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    IPrelaunchActivatedEventArgs,
    IViewSwitcherProvider,
    ILaunchActivatedEventArgs2,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the arguments that are passed to the app during its launch activation.</summary>
    /// <returns>The list of arguments. This value can be used to control the behavior of the app when it is launched through a secondary tile or through a toast.</returns>
    public extern string Arguments { [MethodImpl] get; }

    /// <summary>Gets the ID of the tile that was invoked to launch the app.</summary>
    /// <returns>The ID of the tile that launched the app. If the app's main tile was used, this value is "App". If a secondary tile is used, the SecondaryTile.TileId value, assigned to the secondary tile when it was created, is returned.</returns>
    public extern string TileId { [MethodImpl] get; }

    /// <summary>Gets the reason that this app is being activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before this activation.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Indicates whether the app was pre-launched.</summary>
    /// <returns>Indicates whether the app was pre-launched. **TRUE** indicates it was; otherwise, **FALSE**.</returns>
    public extern bool PrelaunchActivated { [MethodImpl] get; }

    /// <summary>Gets the view switcher object that allows you to set the view for the application.</summary>
    /// <returns>The view switcher</returns>
    public extern ActivationViewSwitcher ViewSwitcher { [MethodImpl] get; }

    /// <summary>Gets additional information that is provided when the user launches your app from a tile. This will be **null** if the app is not launched from its tile or if the app is launched on a platform that doesn't support this property.</summary>
    /// <returns>Information about the tile that launched the app.</returns>
    public extern TileActivatedInfo TileActivatedInfo { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
