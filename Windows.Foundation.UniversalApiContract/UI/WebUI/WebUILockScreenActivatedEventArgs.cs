// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUILockScreenActivatedEventArgs
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
  /// <summary>Represents arguments used when the lock screen is activated.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUILockScreenActivatedEventArgs : 
    ILockScreenActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets information about the app activation operation.</summary>
    /// <returns>The information.</returns>
    public extern object Info { [MethodImpl] get; }

    /// <summary>Gets and activation kind for the app activation operation.</summary>
    /// <returns>The activation kind.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the previous execution state.</summary>
    /// <returns>The previous execution state of the app.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Gets the object that manages an app activation operation.</summary>
    /// <returns>The object that manages an app activation operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user the app was activated for.</summary>
    /// <returns>The user the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
