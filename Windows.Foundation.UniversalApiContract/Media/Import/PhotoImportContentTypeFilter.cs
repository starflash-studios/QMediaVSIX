// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportContentTypeFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the content types that are included in a photo import operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportContentTypeFilter
  {
    /// <summary>Include only images.</summary>
    OnlyImages,
    /// <summary>Include only videos.</summary>
    OnlyVideos,
    /// <summary>Include images and videos.</summary>
    ImagesAndVideos,
    /// <summary>Include images and videos located in the Camera Roll directory or any of its subdirectories.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] ImagesAndVideosFromCameraRoll,
  }
}
