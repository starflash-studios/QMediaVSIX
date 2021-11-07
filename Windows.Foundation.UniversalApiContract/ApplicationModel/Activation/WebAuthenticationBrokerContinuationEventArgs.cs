// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information to an app that was launched after being suspended for a web authentication broker operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebAuthenticationBrokerContinuationEventArgs : 
    IWebAuthenticationBrokerContinuationEventArgs,
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the WebAuthenticationResult object returned from the web authentication broker operation.</summary>
    /// <returns>The result of the web authentication broker operation.</returns>
    public extern WebAuthenticationResult WebAuthenticationResult { [MethodImpl] get; }

    /// <summary>Gets a set of values populated by the app before a web authentication broker operation that deactivates the app in order to provide context when the app is activated.</summary>
    /// <returns>A set of values populated by the app before a web authentication broker operation that deactivates the app.</returns>
    public extern ValueSet ContinuationData { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The ActivationKind.WebAuthenticationBrokerContinuation enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets a SplashScreen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }
  }
}
