// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIWebAccountProviderActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Provider;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Represents the arguments involved in activated a web account provider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUIWebAccountProviderActivatedEventArgs : 
    IWebAccountProviderActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the web account provider operation.</summary>
    /// <returns>The operation.</returns>
    public extern IWebAccountProviderOperation Operation { [MethodImpl] get; }

    /// <summary>Gets the kind of activation.</summary>
    /// <returns>The kind of activation.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the previous execution state of the app.</summary>
    /// <returns>The execution state.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen.</summary>
    /// <returns>The splash screen.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the activated operation.</summary>
    /// <returns>The activated operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
