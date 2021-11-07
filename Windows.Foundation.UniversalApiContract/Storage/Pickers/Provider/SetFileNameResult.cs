// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.SetFileNameResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Indicates the result of a call to the fileSavePickerUI.trySetFileName method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SetFileNameResult
  {
    /// <summary>The file name and extension were updated successfully.</summary>
    Succeeded,
    /// <summary>The file name and extension were not updated because the extension wasn't one of the allowedFileTypes.</summary>
    NotAllowed,
    /// <summary>The file name and extension were not updated because the file picker UI wasn't available. The file picker UI is only available while the user is interacting with your app.</summary>
    Unavailable,
  }
}
