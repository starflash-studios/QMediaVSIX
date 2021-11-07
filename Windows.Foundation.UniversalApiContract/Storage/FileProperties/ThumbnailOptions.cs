// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.ThumbnailOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Describes the behavior used to retrieve and adjust thumbnails, including the size and quality of the image and how quickly the thumbnail image is retrieved.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum ThumbnailOptions : uint
  {
    /// <summary>No options.</summary>
    None = 0,
    /// <summary>Retrieve a thumbnail only if it is cached or embedded in the file.</summary>
    ReturnOnlyIfCached = 1,
    /// <summary>Scale the thumbnail to the requested size.</summary>
    ResizeThumbnail = 2,
    /// <summary>Default. Increase requested size based on the Pixels Per Inch (PPI) of the display.</summary>
    UseCurrentScale = 4,
  }
}
