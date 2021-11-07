// Decompiled with JetBrains decompiler
// Type: Windows.Storage.KnownFolderId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Provides values that identify storage folders.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum KnownFolderId
  {
    /// <summary>App Captures folder.</summary>
    AppCaptures,
    /// <summary>Camera Roll folder.</summary>
    CameraRoll,
    /// <summary>Documents library folder.</summary>
    DocumentsLibrary,
    /// <summary>HomeGroup folder.</summary>
    HomeGroup,
    /// <summary>The folder of media server (Digital Living Network Alliance (DLNA)) devices.</summary>
    MediaServerDevices,
    /// <summary>Music library folder.</summary>
    MusicLibrary,
    /// <summary>Objects 3D folder.</summary>
    Objects3D,
    /// <summary>Pictures library folder.</summary>
    PicturesLibrary,
    /// <summary>Playlists folder.</summary>
    Playlists,
    /// <summary>Recorded calls folder.</summary>
    RecordedCalls,
    /// <summary>Removable devices folder.</summary>
    RemovableDevices,
    /// <summary>Saved pictures folder.</summary>
    SavedPictures,
    /// <summary>Screenshots folder.</summary>
    Screenshots,
    /// <summary>Videos library folder.</summary>
    VideosLibrary,
    /// <summary>All app modifications folder.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] AllAppMods,
    /// <summary>Current app modifications folder.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] CurrentAppMods,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] DownloadsFolder,
  }
}
