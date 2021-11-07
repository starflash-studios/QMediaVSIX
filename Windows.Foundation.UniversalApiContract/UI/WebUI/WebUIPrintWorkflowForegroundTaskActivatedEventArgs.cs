// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIPrintWorkflowForegroundTaskActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Provides data when an app is launched as part of a print workflow.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class WebUIPrintWorkflowForegroundTaskActivatedEventArgs : 
    IActivatedEventArgs,
    IActivatedEventArgsDeferral
  {
    /// <summary>Gets the activation type.</summary>
    /// <returns>The activation type.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>The execution state of the app before it was activated.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the operation that activated the app.</summary>
    /// <returns>The operation that activated the app.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }
  }
}
