// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIBarcodeScannerPreviewActivatedEventArgs
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
  /// <summary>Provides event info when a barcode scanner preview activates the app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class WebUIBarcodeScannerPreviewActivatedEventArgs : 
    IBarcodeScannerPreviewActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser,
    IActivatedEventArgsDeferral
  {
    /// <summary>Gets a connection ID used to match the service connection.</summary>
    /// <returns>The connection ID used to match the service connection.</returns>
    public extern string ConnectionId { [MethodImpl] get; }

    /// <summary>Gets the type of action that activated the app.</summary>
    /// <returns>The type of action that activated the app.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>The app's previous execution state.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object, which provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user for the barcode scanner preview.</summary>
    /// <returns>The user who activated the app.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the object that manages the app's activation.</summary>
    /// <returns>An object that manages the app's activation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }
  }
}
