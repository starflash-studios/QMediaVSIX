// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FileSavePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Pickers
{
  /// <summary>Represents a file picker that lets the user choose the file name, extension, and storage location for a file.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFileSavePickerStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileSavePicker : 
    IFileSavePicker2,
    IFileSavePicker3,
    IFileSavePicker,
    IFileSavePicker4
  {
    /// <summary>Creates a new instance of a FileSavePicker.</summary>
    [MethodImpl]
    public extern FileSavePicker();

    /// <summary>Gets a set of values to be populated by the app before a PickSaveFileAndContinue operation that deactivates the app in order to provide context when the app is activated. (Windows Phone 8.x app)</summary>
    /// <returns>A set of values to be populated by the app before a PickSaveFileAndContinue operation</returns>
    public extern ValueSet ContinuationData { [MethodImpl] get; }

    /// <summary>**Obsolete as of Windows 10; use PickSaveFileAsync instead.** Shows the file picker so that the user can save a file, deactivating and the app and reactivating it when the operation is complete. (Windows Phone 8.x app)</summary>
    /// <deprecated type="deprecate">Instead, use PickSaveFileAsync</deprecated>
    [Deprecated("Instead, use PickSaveFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickSaveFileAndContinue();

    /// <summary>Gets or sets an ID that specifies the enterprise that owns the file.</summary>
    /// <returns>An ID that specifies the enterprise that owns the file.</returns>
    public extern string EnterpriseId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the settings identifier associated with the current FileSavePicker instance.</summary>
    /// <returns>The settings identifier.</returns>
    public extern string SettingsIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the location that the file save picker suggests to the user as the location to save a file.</summary>
    /// <returns>The initial suggested location for saving a file.</returns>
    public extern PickerLocationId SuggestedStartLocation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the label text of the commit button in the file picker UI.</summary>
    /// <returns>The label text.</returns>
    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of valid file types that the user can choose to assign to a file.</summary>
    /// <returns>A FilePickerFileTypesOrderedMap object that contains a collection of valid file types (extensions) that the user can use to save a file. Each element in this collection maps a display name to a corresponding collection of file name extensions. The key is a single string, the value is a list/vector of strings representing one or more extension choices.</returns>
    public extern IMap<string, IVector<string>> FileTypeChoices { [MethodImpl] get; }

    /// <summary>**Do not use this property. Use the FileTypeChoices property instead.** Gets or sets the default file name extension that the fileSavePicker gives to files to be saved.</summary>
    /// <returns>The default file name extension.</returns>
    public extern string DefaultFileExtension { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the storageFile that the file picker suggests to the user for saving a file.</summary>
    /// <returns>The suggested storage file object to save.</returns>
    public extern StorageFile SuggestedSaveFile { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the file name that the file save picker suggests to the user.</summary>
    /// <returns>The initial suggested file name.</returns>
    public extern string SuggestedFileName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Shows the file picker so that the user can save a file and set the file name, extension, and location of the file to be saved. (UWP app)</summary>
    /// <returns>When the call to this method completes successfully, it returns a storageFile object that was created to represent the saved file. The file name, extension, and location of this storageFile match those specified by the user, but the file has no content.</returns>
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> PickSaveFileAsync();

    /// <summary>Gets info about the user for which the FileSavePicker was created. Use this property for multi-user applications.</summary>
    /// <returns>The user for which the FileSavePicker was created.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Creates a FileSavePicker that is scoped to the personal directory of the specified user. Use this method for multi-user applications.</summary>
    /// <param name="user">The user for which to create the FileSavePicker.</param>
    /// <returns>The new FileSavePicker that was created.</returns>
    [MethodImpl]
    public static extern FileSavePicker CreateForUser(User user);
  }
}
