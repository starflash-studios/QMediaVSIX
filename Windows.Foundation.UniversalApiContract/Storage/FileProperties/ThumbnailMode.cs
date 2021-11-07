// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.ThumbnailMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Describes the purpose of the thumbnail to determine how to adjust the thumbnail image to retrieve.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ThumbnailMode
  {
    /// <summary>To display previews of picture files.</summary>
    PicturesView,
    /// <summary>To display previews of video files.</summary>
    VideosView,
    /// <summary>To display previews of music files.</summary>
    MusicView,
    /// <summary>To display previews of document files.</summary>
    DocumentsView,
    /// <summary>To display previews of files (or other items) in a list.</summary>
    ListView,
    /// <summary>To display a preview of any single item (like a file, folder, or file group).</summary>
    SingleItem,
  }
}
