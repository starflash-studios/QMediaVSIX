// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIStartupTaskActivatedEventArgs
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
  /// <summary>Provides information when an app is activated at device startup or user login.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebUIStartupTaskActivatedEventArgs : 
    IStartupTaskActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser,
    IActivatedEventArgsDeferral
  {
    /// <summary>Gets the unique identifier for your task.</summary>
    /// <returns>The unique identifier for your task.</returns>
    public extern string TaskId { [MethodImpl] get; }

    /// <summary>Gets the reason that this app is being activated.</summary>
    /// <returns>The expected value is **ActivationKind.StartupTask**.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>The execution state before the app was activated.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets a SplashScreen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user who launched the app.</summary>
    /// <returns>The user who launched the app.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the operation that activated the app.</summary>
    /// <returns>The operation that activated the app.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }
  }
}
