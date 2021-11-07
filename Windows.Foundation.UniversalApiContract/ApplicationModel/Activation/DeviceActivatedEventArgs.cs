// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.DeviceActivatedEventArgs
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
  /// <summary>Provides information for a device that invokes AutoPlay.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceActivatedEventArgs : 
    IDeviceActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    IViewSwitcherProvider,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the device identifier for the device that invoked AutoPlay.</summary>
    /// <returns>The device identifier for the device that invoked AutoPlay.</returns>
    public extern string DeviceInformationId { [MethodImpl] get; }

    /// <summary>Gets the action associated with the activated device.</summary>
    /// <returns>The action associated with the activated device.</returns>
    public extern string Verb { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object which provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Gets the view switcher object that allows you to set the view for the application.</summary>
    /// <returns>Use the ActivationViewSwitcher to show or switch the view in response to the activation. The value will be **null** in hosted scenarios such as Share and File Picker activations.</returns>
    public extern ActivationViewSwitcher ViewSwitcher { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
