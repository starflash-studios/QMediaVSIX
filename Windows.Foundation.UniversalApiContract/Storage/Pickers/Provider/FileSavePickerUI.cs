// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.FileSavePickerUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Used to interact with the file picker when your app provides a save location with the File Save Picker contract.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileSavePickerUI : IFileSavePickerUI
  {
    /// <summary>Gets or sets a title to display in the file picker UI that identifies the location that the file picker is displaying to the user.</summary>
    /// <returns>The title to display in the file picker UI. This title should identify the location and type of files that the user can see on the app page (which is hosted by the file picker) of the app that is providing files.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of file types (extensions) that can be saved to the app that is providing the save location.</summary>
    /// <returns>The list of file types that can be saved.</returns>
    public extern IVectorView<string> AllowedFileTypes { [MethodImpl] get; }

    /// <summary>Gets an identifier for the current context of the file picker.</summary>
    /// <returns>The identifier for the current context of the file picker.</returns>
    public extern string SettingsIdentifier { [MethodImpl] get; }

    /// <summary>Gets the full file name of the file to save, including the file type extension. The file name and extension are specified by the user.</summary>
    /// <returns>The full file name, including the file type extension.</returns>
    public extern string FileName { [MethodImpl] get; }

    /// <summary>Tries to set the file name and extension in the file picker UI.</summary>
    /// <param name="value">The file name and extension that are used to update the file name text box and file type drop-down menu in the file picker UI.</param>
    /// <returns>The enumeration value that indicates whether the file name and extension were updated in the file picker UI.</returns>
    [MethodImpl]
    public extern SetFileNameResult TrySetFileName(string value);

    /// <summary>Fired when the user changes the file name in the file name text box or changes the extension in the file type drop-down menu.</summary>
    public extern event TypedEventHandler<FileSavePickerUI, object> FileNameChanged;

    /// <summary>Fires when the user commits a file to be saved in the file picker.</summary>
    public extern event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested;
  }
}
