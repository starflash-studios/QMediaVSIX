// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.LockScreenActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an event that occurs when the app is activated as the lock screen.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LockScreenActivatedEventArgs : 
    ILockScreenActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets an object that allows an app that is activated as the lock screen to get the same data that the default lock screen can access, and to register for updates to that data.</summary>
    /// <returns>An object that allows an app that is activated as the lock screen to get the same data that the default lock screen can access, and to register for updates to that data.</returns>
    public extern object Info { [MethodImpl] get; }

    /// <summary>Gets the reason for the activation of the app for this event.</summary>
    /// <returns>The reason for the activation of the app for this event. For the event that occurs when an app is activated as the lock screen, this value is **ActivationKind.LockScreen**.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before the app was activated as the lock screen.</summary>
    /// <returns>The execution state of the app before the app was activated as the lock screen.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object that provides information about the transition from the splash screen to the activated app.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user the app was activated for.</summary>
    /// <returns>The user the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
