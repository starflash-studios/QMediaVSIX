// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowUIActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Contains contextual information about a print workflow foreground task that has been activated.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class PrintWorkflowUIActivatedEventArgs : 
    IPrintWorkflowUIActivatedEventArgs,
    IActivatedEventArgsWithUser,
    IActivatedEventArgs
  {
    /// <summary>Gets the print workflow session object that should manage the behavior of the foreground task that was activated.</summary>
    /// <returns>The single print workflow foreground session.</returns>
    public extern PrintWorkflowForegroundSession PrintWorkflowSession { [MethodImpl] get; }

    /// <summary>Gets the reason that this app was activated.</summary>
    /// <returns>A value indicating the type of task this app was activated to execute. In this case, it should be ActivationKind.PrintWorkflowForegroundTask.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>The execution state.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user that the foreground app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
