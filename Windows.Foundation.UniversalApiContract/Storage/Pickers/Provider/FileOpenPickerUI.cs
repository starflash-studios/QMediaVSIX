// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.FileOpenPickerUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Used to interact with the file picker if your app provides files with the File Open Picker contract.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileOpenPickerUI : IFileOpenPickerUI
  {
    /// <summary>Adds the specified file to the list of files that the user has chosen.</summary>
    /// <param name="id">A unique identifier of the file to add.</param>
    /// <param name="file">The file to add to the list of files that the user has chosen.</param>
    /// <returns>The enumeration value that indicates the result of this addFile method.</returns>
    [MethodImpl]
    public extern AddFileResult AddFile(string id, IStorageFile file);

    /// <summary>Removes the specified file from the list of files the user has chosen.</summary>
    /// <param name="id">The identifier of the file to remove.</param>
    [MethodImpl]
    public extern void RemoveFile(string id);

    /// <summary>Determines whether the specified file is in the list of files that the user has chosen.</summary>
    /// <param name="id">The identifier of the file.</param>
    /// <returns>True if the file is in the basket; otherwise false.</returns>
    [MethodImpl]
    public extern bool ContainsFile(string id);

    /// <summary>Indicates whether the specified file can be added to the list of files the user has chosen.</summary>
    /// <param name="file">The file to test.</param>
    /// <returns>True if the file can be added to the file picker UI; otherwise false.</returns>
    [MethodImpl]
    public extern bool CanAddFile(IStorageFile file);

    /// <summary>Gets a list of file types (extensions) that the user can choose.</summary>
    /// <returns>The list of allowed file types.</returns>
    public extern IVectorView<string> AllowedFileTypes { [MethodImpl] get; }

    /// <summary>Gets an enumeration value that indicates whether the file picker currently limits selection to single files, or if multiple files can be selected.</summary>
    /// <returns>The enumeration value that indicates the current selection mode.</returns>
    public extern FileSelectionMode SelectionMode { [MethodImpl] get; }

    /// <summary>Gets an identifier for the current context of the file picker.</summary>
    /// <returns>The identifier for the current context of the file picker.</returns>
    public extern string SettingsIdentifier { [MethodImpl] get; }

    /// <summary>Gets or sets a title to display in the file picker UI that identifies the location that the file picker is displaying to the user.</summary>
    /// <returns>The title to display in the file picker UI. This title should identify the location and type of files that the user can see on the app page (which is hosted by the file picker) of the app that is providing files.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Fires when the user removes a file from the list of files that the user has chosen if that file was added by the app that is providing files.</summary>
    public extern event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved;

    /// <summary>Fires when the user closes the file picker.</summary>
    public extern event TypedEventHandler<FileOpenPickerUI, PickerClosingEventArgs> Closing;
  }
}
