// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ToastNotificationActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an event that occurs when the app is activated because a user tapped on the body of a toast notification or performed an action inside a toast notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ToastNotificationActivatedEventArgs : 
    IToastNotificationActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser,
    IApplicationViewActivatedEventArgs
  {
    /// <summary>Gets the arguments that the app can retrieve after it is activated through an interactive toast notification.</summary>
    /// <returns>The arguments that the app can retrieve after it is activated through an interactive toast notification. The value of this property is defined previously in the XML that describes the data to deliver for the toast notification. The following elements and attributes of that XML define the value:</returns>
    public extern string Argument { [MethodImpl] get; }

    /// <summary>Gets a set of values that you can use to obtain the user input from an interactive toast notification.</summary>
    /// <returns>A set of values that you can use to obtain the user input from an interactive toast notification.</returns>
    public extern ValueSet UserInput { [MethodImpl] get; }

    /// <summary>Gets the reason for the activation of the app for this event.</summary>
    /// <returns>The reason for the activation of the app for this event. For the event that occurs when the app is activated because a user tapped on the body of a toast notification or performed an action inside a toast notification, this value is **ActivationKind.ToastNotification**.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before the app was activated because a user tapped on the body of a toast notification or performed an action inside a toast notification.</summary>
    /// <returns>The execution state of the app before the app was activated because a user tapped on the body of a toast notification or performed an action inside a toast notification.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object that provides information about the transition from the splash screen to the activated app.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user the app was activated for.</summary>
    /// <returns>The user the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }
  }
}
