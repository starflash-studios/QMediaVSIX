// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIRestrictedLaunchActivatedEventArgs
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
  /// <summary>Provides event information when a restricted app is launched.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUIRestrictedLaunchActivatedEventArgs : 
    IRestrictedLaunchActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets information about a shared context for the restricted launch.</summary>
    /// <returns>The object that provides shared context information.</returns>
    public extern object SharedContext { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the app activated operation.</summary>
    /// <returns>The activation operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
