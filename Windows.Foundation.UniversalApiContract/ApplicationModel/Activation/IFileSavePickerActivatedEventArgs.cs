// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when the user saves a file through the file picker and selects the app as the location.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2176949489, 29926, 17287, 130, 235, 187, 143, 214, 75, 67, 70)]
  public interface IFileSavePickerActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>The letterbox UI of the file picker that is displayed when the user saves a file and selects the app as the save location.</summary>
    /// <returns>The letterbox UI of the file picker that is displayed when the user saves a file and selects the app as the location.</returns>
    FileSavePickerUI FileSavePickerUI { get; }
  }
}
