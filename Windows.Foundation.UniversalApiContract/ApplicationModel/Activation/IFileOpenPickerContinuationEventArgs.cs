// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileOpenPickerContinuationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an activated event that fires after the app was suspended for a file open picker operation.</summary>
  /// <deprecated type="deprecate">IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4042932026, 54504, 19155, 156, 52, 35, 8, 243, 47, 206, 201)]
  public interface IFileOpenPickerContinuationEventArgs : 
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the list of files selected by the user during the file open picker operation.</summary>
    /// <returns>The list of files selected by the user during the file open picker operation.</returns>
    IVectorView<StorageFile> Files { [Deprecated("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
