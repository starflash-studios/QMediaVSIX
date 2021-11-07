// Decompiled with JetBrains decompiler
// Type: Windows.Storage.KnownFolders
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>Provides access to common locations that contain user content. This includes content from a user's local libraries (such as Documents, Pictures, Music, and Videos), HomeGroup, removable devices, and media server devices.</summary>
  [Static(typeof (IKnownFoldersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersCameraRollStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersPlaylistsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKnownFoldersStatics3), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersStatics4), 655360, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownFoldersSavedPicturesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KnownFolders
  {
    /// <summary>
    /// </summary>
    /// <param name="folderId">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<KnownFoldersAccessStatus> RequestAccessAsync(
      KnownFolderId folderId);

    /// <summary>
    /// </summary>
    /// <param name="user">
    /// </param>
    /// <param name="folderId">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<KnownFoldersAccessStatus> RequestAccessForUserAsync(
      User user,
      KnownFolderId folderId);

    /// <summary>
    /// </summary>
    /// <param name="folderId">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> GetFolderAsync(
      KnownFolderId folderId);

    /// <summary>Static method that returns a specified known folder for a User.</summary>
    /// <param name="user">The User for which the folder is returned. Use `null` for the current user. In context of this API, current user refers to the user context of the process from where the API call is made.</param>
    /// <param name="folderId">The ID of the folder to be returned.</param>
    /// <returns>When this method completes, it returns the requested StorageFolder object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> GetFolderForUserAsync(
      User user,
      KnownFolderId folderId);

    /// <summary>Gets the Objects 3D folder.</summary>
    /// <returns>The Objects 3D folder.</returns>
    public static extern StorageFolder Objects3D { [MethodImpl] get; }

    /// <summary>Gets the App Captures folder.</summary>
    /// <returns>The App Captures folder.</returns>
    public static extern StorageFolder AppCaptures { [MethodImpl] get; }

    /// <summary>Gets the recorded calls folder.</summary>
    /// <returns>The recorded calls folder.</returns>
    public static extern StorageFolder RecordedCalls { [MethodImpl] get; }

    /// <summary>Gets the Saved Pictures folder.</summary>
    /// <returns>The Saved Pictures folder.</returns>
    public static extern StorageFolder SavedPictures { [MethodImpl] get; }

    /// <summary>Gets the Camera Roll folder.</summary>
    /// <returns>The Camera Roll folder.</returns>
    public static extern StorageFolder CameraRoll { [MethodImpl] get; }

    /// <summary>Gets the play lists folder.</summary>
    /// <returns>The play lists folder.</returns>
    public static extern StorageFolder Playlists { [MethodImpl] get; }

    /// <summary>Gets the Music library.</summary>
    /// <returns>The Music library.</returns>
    public static extern StorageFolder MusicLibrary { [MethodImpl] get; }

    /// <summary>Gets the Pictures library.</summary>
    /// <returns>The Pictures library.</returns>
    public static extern StorageFolder PicturesLibrary { [MethodImpl] get; }

    /// <summary>Gets the Videos library.</summary>
    /// <returns>The Videos library.</returns>
    public static extern StorageFolder VideosLibrary { [MethodImpl] get; }

    /// <summary>Gets the Documents library. The Documents library is not intended for general use.</summary>
    /// <returns>The Documents library.</returns>
    public static extern StorageFolder DocumentsLibrary { [MethodImpl] get; }

    /// <summary>Gets the HomeGroup folder.</summary>
    /// <returns>The HomeGroup folder.</returns>
    public static extern StorageFolder HomeGroup { [MethodImpl] get; }

    /// <summary>Gets the removable devices folder.</summary>
    /// <returns>The removable devices folder.</returns>
    public static extern StorageFolder RemovableDevices { [MethodImpl] get; }

    /// <summary>Gets the folder of media server (Digital Living Network Alliance (DLNA)) devices.</summary>
    /// <returns>The folder of media server (Digital Living Network Alliance (DLNA)) devices.</returns>
    public static extern StorageFolder MediaServerDevices { [MethodImpl] get; }
  }
}
