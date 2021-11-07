// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIFileOpenPickerContinuationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Provides information about an activated event that fires after the app was suspended for a file open picker operation.</summary>
  /// <deprecated type="deprecate">WebUIFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("WebUIFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUIFileOpenPickerContinuationEventArgs : 
    IFileOpenPickerContinuationEventArgs,
    IContinuationActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the files for which the app was activated.</summary>
    /// <returns>The StorageFile objects representing the files being passed to the app.</returns>
    public extern IVectorView<StorageFile> Files { [Deprecated("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a set of values populated by the app before a FileOpenPicker operation that deactivates the app in order to provide context when the app is activated.</summary>
    /// <returns>A set of values populated by the app before a FileOpenPicker operation that deactivates the app.</returns>
    public extern ValueSet ContinuationData { [MethodImpl] get; }

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
