// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIToastNotificationActivatedEventArgs
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
  /// <summary>Provides information about an event that occurs when the app is activated because a user tapped on the body of a toast notification or performed an action inside a toast notification.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUIToastNotificationActivatedEventArgs : 
    IToastNotificationActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the arguments that the app can retrieve after it is activated through an interactive toast notification.</summary>
    /// <returns>The arguments that the app can retrieve after it is activated through an interactive toast notification. The value of this property is defined previously in the XML that describes the data to deliver for the toast notification. The following elements and attributes of that XML define the value:</returns>
    public extern string Argument { [MethodImpl] get; }

    /// <summary>Gets a set of values that you can use to obtain the user input from an interactive toast notification.</summary>
    /// <returns>A set of values that you can use to obtain the user input from an interactive toast notification. This information consists of pairs of keys and values, in which the keys are the identifiers for the input elements for which the user provided input and the values represent the input from the user. For input elements that specify that the type of the input is text, the value is the string that the user specified.</returns>
    public extern ValueSet UserInput { [MethodImpl] get; }

    /// <summary>Gets the kind of activation.</summary>
    /// <returns>The kind of activation.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the previous execution state of the app.</summary>
    /// <returns>The previous execution state of the app.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the app activation operation.</summary>
    /// <returns>The app activation operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
