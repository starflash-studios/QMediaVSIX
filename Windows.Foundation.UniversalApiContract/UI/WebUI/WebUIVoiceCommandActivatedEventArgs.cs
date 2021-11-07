// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIVoiceCommandActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.SpeechRecognition;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Provides information about an activated event raised when the app is activated from a voice command.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUIVoiceCommandActivatedEventArgs : 
    IVoiceCommandActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the SpeechRecognitionResult object representing the voice command that activated the app.</summary>
    /// <returns>The SpeechRecognitionResult object representing the voice commands that activated the app.</returns>
    public extern SpeechRecognitionResult Result { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the app activation operation.</summary>
    /// <returns>The activated operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
