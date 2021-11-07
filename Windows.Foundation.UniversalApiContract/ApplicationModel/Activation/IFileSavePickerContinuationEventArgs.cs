// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileSavePickerContinuationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an activated event that fires after the app was suspended for a file save picker operation.</summary>
  /// <deprecated type="deprecate">IFileSavePickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("IFileSavePickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(746876897, 15277, 20275, 140, 139, 228, 111, 174, 130, 75, 75)]
  public interface IFileSavePickerContinuationEventArgs : 
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the file selected by the user during the file save picker operation.</summary>
    /// <returns>The file selected by the user during the file save picker operation.</returns>
    StorageFile File { [Deprecated("IFileSavePickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
