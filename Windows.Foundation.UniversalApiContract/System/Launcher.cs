// Decompiled with JetBrains decompiler
// Type: Windows.System.Launcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  /// <summary>Starts the default app associated with the specified file or URI.</summary>
  [Static(typeof (ILauncherStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ILauncherStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ILauncherStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ILauncherStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ILauncherStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class Launcher
  {
    /// <summary>Launches File Explorer and displays the contents of the specified folder.</summary>
    /// <param name="path">A filepath to the folder to open.</param>
    /// <returns>The result of the operation.</returns>
    [Overload("LaunchFolderPathAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderPathAsync(string path);

    /// <summary>Launches File Explorer with the specified options and displays the contents of the specified folder.</summary>
    /// <param name="path">A filepath to the folder to open.</param>
    /// <param name="options">Options that specify the amount of screen space that File Explorer fills, and the list of items to select in the specified folder.</param>
    /// <returns>The result of the operation.</returns>
    [Overload("LaunchFolderPathWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderPathAsync(
      string path,
      FolderLauncherOptions options);

    /// <summary>Launches File Explorer and displays the contents of the specified folder.</summary>
    /// <param name="user">The user context to pass to the launched app.</param>
    /// <param name="path">A filepath to the folder to open.</param>
    /// <returns>The result of the operation.</returns>
    [Overload("LaunchFolderPathForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderPathForUserAsync(
      User user,
      string path);

    /// <summary>Launches File Explorer with the specified options and displays the contents of the specified folder.</summary>
    /// <param name="user">The user context to pass to the launched app.</param>
    /// <param name="path">A filepath to the folder to open.</param>
    /// <param name="options">Options that specify the amount of screen space that File Explorer fills, and the list of items to select in the specified folder.</param>
    /// <returns>The result of the operation.</returns>
    [Overload("LaunchFolderPathWithOptionsForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderPathForUserAsync(
      User user,
      string path,
      FolderLauncherOptions options);

    [RemoteAsync]
    [Overload("QueryAppUriSupportAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri);

    [Overload("QueryAppUriSupportWithPackageFamilyNameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri,
      string packageFamilyName);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindAppUriHandlersAsync(
      Uri uri);

    [Overload("LaunchUriForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri);

    [Overload("LaunchUriWithOptionsForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriWithDataForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriForResultsForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    /// <summary>Starts the default app associated with the specified file.</summary>
    /// <param name="file">The file.</param>
    /// <returns>The launch operation.</returns>
    [Overload("LaunchFileAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFileAsync(IStorageFile file);

    /// <summary>Starts the default app associated with the specified file, using the specified options.</summary>
    /// <param name="file">The file.</param>
    /// <param name="options">The launch options for the app.</param>
    /// <returns>The launch operation.</returns>
    [Overload("LaunchFileWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFileAsync(
      IStorageFile file,
      LauncherOptions options);

    [Overload("LaunchUriAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchUriAsync(Uri uri);

    [Overload("LaunchUriWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchUriAsync(
      Uri uri,
      LauncherOptions options);

    /// <summary>Launches File Explorer and displays the contents of the specified folder.</summary>
    /// <param name="folder">The folder to display in File Explorer.</param>
    /// <returns>The result of the operation.</returns>
    [Overload("LaunchFolderAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderAsync(
      IStorageFolder folder);

    /// <summary>Launches File Explorer with the specified options and displays the contents of the specified folder.</summary>
    /// <param name="folder">The folder to display in File Explorer.</param>
    /// <param name="options">Options that specify the amount of screen space that File Explorer fills, and the list of items to select in the specified folder.</param>
    /// <returns>The result of the operation.</returns>
    [Overload("LaunchFolderWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderAsync(
      IStorageFolder folder,
      FolderLauncherOptions options);

    [Overload("LaunchUriForResultsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriWithDataAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchUriAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [RemoteAsync]
    [Overload("QueryUriSupportAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType);

    [Overload("QueryUriSupportWithPackageFamilyNameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType,
      string packageFamilyName);

    /// <summary>Asynchronously query whether an app can be activated for the specified file.</summary>
    /// <param name="file">The file for which to query support.</param>
    /// <returns>A value that indicates whether an application can be activated for the file.</returns>
    [Overload("QueryFileSupportAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file);

    /// <summary>Asynchronously query whether an app with the specified package name can be activated for the specified file.</summary>
    /// <param name="file">The file for which to query support.</param>
    /// <param name="packageFamilyName">The package for which to query support.</param>
    /// <returns>A value that indicates whether an application can be activated for the file.</returns>
    [RemoteAsync]
    [Overload("QueryFileSupportWithPackageFamilyNameAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file,
      string packageFamilyName);

    /// <summary>Enumerate the scheme handlers on the device.</summary>
    /// <param name="scheme">The scheme name that you find to find handlers for. For example, "ms-lens".</param>
    /// <returns>A list of AppInfo s for each application that handles the specified scheme.</returns>
    [RemoteAsync]
    [Overload("FindUriSchemeHandlersAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme);

    /// <summary>Enumerate the scheme handlers on the device.</summary>
    /// <param name="scheme">The scheme name that you find to find handlers for. For example, "ms-lens".</param>
    /// <param name="launchQuerySupportType">Filter the list of handlers by whether they can be launched for results or not.</param>
    /// <returns>A list of AppInfo s for each application that handles the specified scheme.</returns>
    [Overload("FindUriSchemeHandlersWithLaunchUriTypeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme,
      LaunchQuerySupportType launchQuerySupportType);

    /// <summary>Enumerate the file handlers on the device.</summary>
    /// <param name="extension">The file extension that you want to find handlers for. For example, ".bat". Include the leading period '.'.</param>
    /// <returns>A list of AppInfo s for each application that handles the specified file extension.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindFileHandlersAsync(
      string extension);
  }
}
