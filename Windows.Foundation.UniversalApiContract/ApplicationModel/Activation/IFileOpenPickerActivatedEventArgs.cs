// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when the user tries to pick files or folders that are provided by the app.</summary>
  [Guid(1921151106, 21797, 19442, 188, 9, 31, 80, 149, 212, 150, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IFileOpenPickerActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>The letterbox UI of the file picker that is displayed when the user wants to pick files or folders that are provided by the app.</summary>
    /// <returns>The letterbox UI of the file picker that is displayed when the user wants to pick files or folders that are provided by the app.</returns>
    FileOpenPickerUI FileOpenPickerUI { get; }
  }
}
