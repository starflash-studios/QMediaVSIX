// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FolderPicker
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
  /// <summary>Represents a UI element that lets the user choose folders.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFolderPickerStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FolderPicker : IFolderPicker2, IFolderPicker, IFolderPicker3
  {
    /// <summary>Creates a new instance of a FolderPicker.</summary>
    [MethodImpl]
    public extern FolderPicker();

    /// <summary>Gets a set of values to be populated by the app before a PickFolderAndContinue operation that deactivates the app in order to provide context when the app is activated. (Windows Phone 8.x app)</summary>
    /// <returns>A set of values to be populated by the app before a PickFolderAndContinue operation that deactivates the app in order to provide context when the app is activated.</returns>
    public extern ValueSet ContinuationData { [MethodImpl] get; }

    /// <summary>**Obsolete as of Windows 10; use PickSingleFolderAsync instead.** Shows the file picker so that the user can pick a folder, deactivating and the app and reactivating it when the operation is complete. (Windows Phone 8.x app)</summary>
    /// <deprecated type="deprecate">Instead, use PickSingleFolderAsync</deprecated>
    [Deprecated("Instead, use PickSingleFolderAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickFolderAndContinue();

    /// <summary>Gets or sets the view mode that the folder picker uses to display items.</summary>
    /// <returns>The view mode.</returns>
    public extern PickerViewMode ViewMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the settings identifier associated with the with the current FolderPicker instance.</summary>
    /// <returns>The settings identifier.</returns>
    public extern string SettingsIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the initial location where the folder picker looks for folders to present to the user.</summary>
    /// <returns>The identifier of the starting location.</returns>
    public extern PickerLocationId SuggestedStartLocation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the label text of the folder picker's commit button.</summary>
    /// <returns>The label text.</returns>
    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of file types that the folder picker displays.</summary>
    /// <returns>A FileExtensionVector object that contains a collection of file types (file name extensions) , such as ".doc" and ".png". File name extensions are stored in this array as string objects.</returns>
    public extern IVector<string> FileTypeFilter { [MethodImpl] get; }

    /// <summary>Shows the folderPicker object so that the user can pick a folder. (UWP app)</summary>
    /// <returns>When the call to this method completes successfully, it returns a storageFolder object that represents the folder that the user picked.</returns>
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> PickSingleFolderAsync();

    /// <summary>Gets info about the user for which the FolderPicker was created. Use this property for multi-user applications.</summary>
    /// <returns>The user for which the FolderPicker was created.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Creates a FolderPicker that is scoped to the personal directory of the specified user. Use this method for multi-user applications.</summary>
    /// <param name="user">The user for which to create the FolderPicker.</param>
    /// <returns>The new FolderPicker that was created.</returns>
    [MethodImpl]
    public static extern FolderPicker CreateForUser(User user);
  }
}
