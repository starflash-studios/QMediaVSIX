// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FileOpenPicker
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
  /// <summary>Represents a UI element that lets the user choose and open files.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFileOpenPickerStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFileOpenPickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FileOpenPicker : 
    IFileOpenPicker2,
    IFileOpenPickerWithOperationId,
    IFileOpenPicker,
    IFileOpenPicker3
  {
    /// <summary>Creates a new instance of a FileOpenPicker.</summary>
    [MethodImpl]
    public extern FileOpenPicker();

    /// <summary>Gets a set of values to be populated by the app before PickSingleFileAndContinue or PickMultipleFilesAndContinue operation that deactivates the app in order to provide context when the app is activated. (Windows Phone 8.x app)</summary>
    /// <returns>A set of values to be populated by the app before PickSingleFileAndContinue or PickMultipleFilesAndContinue operation.</returns>
    public extern ValueSet ContinuationData { [Deprecated("Instead, use PickSingleFileAsync/PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Shows the file picker so that the user can pick one file, potentially deactivating the app and reactivating it when the operation is complete. (Windows Phone 8.x app)</summary>
    /// <deprecated type="deprecate">Instead, use PickSingleFileAsync</deprecated>
    [Deprecated("Instead, use PickSingleFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickSingleFileAndContinue();

    /// <summary>**Obsolete as of Windows 10; use PickSingleFolderAsync instead.** Shows the file picker so that the user can pick multiple files, deactivating and the app and reactivating it when the operation is complete. (Windows Phone 8.x app)</summary>
    /// <deprecated type="deprecate">Instead, use PickMultipleFilesAsync</deprecated>
    [Deprecated("Instead, use PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickMultipleFilesAndContinue();

    /// <summary>Shows the file picker so that the user can pick one file.</summary>
    /// <param name="pickerOperationId">This argument is ignored and has no effect.</param>
    /// <returns>When the call to this method completes successfully, it returns a StorageFile object that represents the file that the user picked.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> PickSingleFileAsync(
      string pickerOperationId);

    /// <summary>Gets or sets the view mode that the file open picker uses to display items.</summary>
    /// <returns>The view mode.</returns>
    public extern PickerViewMode ViewMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the settings identifier associated with the state of the file open picker.</summary>
    /// <returns>The settings identifier.</returns>
    public extern string SettingsIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the initial location where the file open picker looks for files to present to the user.</summary>
    /// <returns>The identifier of the starting location.</returns>
    public extern PickerLocationId SuggestedStartLocation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the label text of the file open picker's commit button.</summary>
    /// <returns>The label text.</returns>
    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of file types that the file open picker displays.</summary>
    /// <returns>A fileExtensionVector object that contains a collection of file types (file name extensions) , such as ".doc" and ".png". File name extensions are stored in this array as string objects.</returns>
    public extern IVector<string> FileTypeFilter { [MethodImpl] get; }

    /// <summary>Shows the file picker so that the user can pick one file.</summary>
    /// <returns>When the call to this method completes successfully, it returns a StorageFile object that represents the file that the user picked.</returns>
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> PickSingleFileAsync();

    /// <summary>Shows the file picker so that the user can pick multiple files. (UWP app)</summary>
    /// <returns>When the call to this method completes successfully, it returns a filePickerSelectedFilesArray object that contains all the files that were picked by the user. Picked files in this array are represented by storageFile objects.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> PickMultipleFilesAsync();

    /// <summary>Gets info about the user for which the FileOpenPicker was created. Use this property for multi-user applications.</summary>
    /// <returns>The user for which the FileOpenPicker was created.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Creates a FileOpenPicker that is scoped to the personal directory of the specified user. Use this method for multi-user applications.</summary>
    /// <param name="user">The user for which to create the FileOpenPicker.</param>
    /// <returns>The new FileOpenPicker that was created.</returns>
    [MethodImpl]
    public static extern FileOpenPicker CreateForUser(User user);

    /// <summary>Resumes the picking operation to retrieve the user-selected file if the user navigates away from the app after the picker operation has completed and the app is suspended.</summary>
    /// <deprecated type="deprecate">Instead, use PickSingleFileAsync</deprecated>
    /// <returns>When the call to this method completes successfully, it returns a StorageFile object that represents the file that the user picked.</returns>
    [RemoteAsync]
    [Deprecated("Instead, use PickSingleFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> ResumePickSingleFileAsync();
  }
}
