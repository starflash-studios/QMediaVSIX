// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFolderPickerContinuationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an activated event that fires after the app was suspended for a folder picker operation.</summary>
  /// <deprecated type="deprecate">IFolderPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1367876454, 40779, 18831, 190, 176, 66, 104, 79, 110, 28, 41)]
  [Deprecated("IFolderPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public interface IFolderPickerContinuationEventArgs : 
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the folder selected by the user during the folder picker operation.</summary>
    /// <returns>The folder selected by the user during the folder picker operation.</returns>
    StorageFolder Folder { [Deprecated("IFolderPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
