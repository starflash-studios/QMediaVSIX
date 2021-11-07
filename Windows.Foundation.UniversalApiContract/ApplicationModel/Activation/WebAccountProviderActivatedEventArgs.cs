// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.WebAccountProviderActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Provider;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information to an app activated as a result of a web account provider operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebAccountProviderActivatedEventArgs : 
    IWebAccountProviderActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the web account provider operation.</summary>
    /// <returns>Gets the web account provider operation.</returns>
    public extern IWebAccountProviderOperation Operation { [MethodImpl] get; }

    /// <summary>Gets the kind of web account provider activation.</summary>
    /// <returns>The kind of web account provider activation.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>The execution state of the app before it was activated.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object which provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object which provides information about the transition from the splash screen to the activated app.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user the app was activated for.</summary>
    /// <returns>The user the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
