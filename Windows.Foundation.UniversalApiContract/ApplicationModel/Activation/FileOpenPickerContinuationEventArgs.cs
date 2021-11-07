// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.FileOpenPickerContinuationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an activated event that fires after the app was suspended for a file open picker operation.</summary>
  /// <deprecated type="deprecate">FileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("FileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class FileOpenPickerContinuationEventArgs : 
    IFileOpenPickerContinuationEventArgs,
    IContinuationActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the list of files selected by the user during the file open picker operation.</summary>
    /// <returns>The list of files selected by the user during the file open picker operation.</returns>
    public extern IVectorView<StorageFile> Files { [Deprecated("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a set of values populated by the app before a FileOpenPicker operation that deactivates the app in order to provide context when the app is activated.</summary>
    /// <returns>A set of values populated by the app before a FileOpenPicker operation that deactivates the app.</returns>
    public extern ValueSet ContinuationData { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The ActivationKind.ContinueFileOpenPicker enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets a SplashScreen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
