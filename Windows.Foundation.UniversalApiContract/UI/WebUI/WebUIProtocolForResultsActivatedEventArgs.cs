// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIProtocolForResultsActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Describes the activation arguments when an app is launched via LaunchUriForResultsAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUIProtocolForResultsActivatedEventArgs : 
    IProtocolForResultsActivatedEventArgs,
    IActivatedEventArgs,
    IProtocolActivatedEventArgs,
    IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData,
    IApplicationViewActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets info about the protocol for results operation that triggered the activation.</summary>
    /// <returns>Info about the protocol for results operation that triggered the activation.</returns>
    public extern ProtocolForResultsOperation ProtocolForResultsOperation { [MethodImpl] get; }

    /// <summary>Gets the kind of activation.</summary>
    /// <returns>The kind of activation.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the previous execution state.</summary>
    /// <returns>The previous state.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) for which the app was activated.</summary>
    /// <returns>The Uniform Resource Identifier (URI) for which the app was activated.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets the family name of the caller's package.</summary>
    /// <returns>The family name of the caller's package.</returns>
    public extern string CallerPackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets the data associated with the activation.</summary>
    /// <returns>The data associated with the activation.</returns>
    public extern ValueSet Data { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Gets the app activation operation.</summary>
    /// <returns>The activated operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
