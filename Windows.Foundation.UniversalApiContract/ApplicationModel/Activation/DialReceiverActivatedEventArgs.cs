// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.DialReceiverActivatedEventArgs
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
  /// <summary>Provides data when an app is activated from another app by using the DIAL protocol.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DialReceiverActivatedEventArgs : 
    IDialReceiverActivatedEventArgs,
    ILaunchActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    IViewSwitcherProvider,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the name of the app that invoked the dial receiver app.</summary>
    /// <returns>The name of the app that invoked the dial receiver app.</returns>
    public extern string AppName { [MethodImpl] get; }

    /// <summary>Gets the arguments passed by the calling app.</summary>
    /// <returns>The arguments passed by the calling app.</returns>
    public extern string Arguments { [MethodImpl] get; }

    /// <summary>Gets the unique tile identifier for the calling app.</summary>
    /// <returns>The unique tile identifier for the calling app.</returns>
    public extern string TileId { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The ActivationKind.DialReceiver enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>The execution state of the app before it was activated.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object, which provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Gets the view switcher object that allows you to set the view for the application.</summary>
    /// <returns>Use the ActivationViewSwitcher to show or switch the view in response to the activation. The value will be **null** in hosted scenarios such as Share and File Picker activations.</returns>
    public extern ActivationViewSwitcher ViewSwitcher { [MethodImpl] get; }

    /// <summary>Gets the user the app was activated for.</summary>
    /// <returns>The user the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
