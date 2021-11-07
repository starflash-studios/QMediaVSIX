// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ProtocolForResultsActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Received by an application when it is launched by another application with the expectation that it will return results back to the caller.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProtocolForResultsActivatedEventArgs : 
    IProtocolForResultsActivatedEventArgs,
    IActivatedEventArgs,
    IProtocolActivatedEventArgs,
    IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData,
    IApplicationViewActivatedEventArgs,
    IViewSwitcherProvider,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the **ProtocolForResultsOperation** that you use to signal that your app is ready to return to the app that launched it for results.</summary>
    /// <returns>The **ProtocolForResultsOperation** object that you can use to signal that your app is ready to return by calling its ProtocolForResultsOperation.ReportCompleted method.</returns>
    public extern ProtocolForResultsOperation ProtocolForResultsOperation { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>A  enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>An ApplicationExecutionState enumeration value.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets a SplashScreen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) used to activate the app.</summary>
    /// <returns>The Uniform Resource Identifier (URI).</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets the package family name of the application that activated the current application.</summary>
    /// <returns>The package family name of the application that activated the current application.</returns>
    public extern string CallerPackageFamilyName { [MethodImpl] get; }

    /// <summary>Data received from the application that activated the current application.</summary>
    /// <returns>User-defined data. May be **null**.</returns>
    public extern ValueSet Data { [MethodImpl] get; }

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
