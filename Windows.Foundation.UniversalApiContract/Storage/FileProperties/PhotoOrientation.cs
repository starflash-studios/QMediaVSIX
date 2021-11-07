// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.PhotoOrientation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Indicates the Exchangeable Image File (EXIF) orientation flag of the photo. This flag describes how to rotate the photo to display it correctly.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoOrientation
  {
    /// <summary>An orientation flag is not set.</summary>
    Unspecified,
    /// <summary>No rotation needed. The photo can be displayed using its current orientation.</summary>
    Normal,
    /// <summary>Flip the photo horizontally.</summary>
    FlipHorizontal,
    /// <summary>Rotate the photo 180 degrees.</summary>
    Rotate180,
    /// <summary>Flip the photo vertically.</summary>
    FlipVertical,
    /// <summary>Rotate the photo counter-clockwise 90 degrees and then flip it horizontally.</summary>
    Transpose,
    /// <summary>Rotate the photo counter-clockwise 270 degrees.</summary>
    Rotate270,
    /// <summary>Rotate the photo counter-clockwise 270 degrees and then flip it horizontally.</summary>
    Transverse,
    /// <summary>Rotate the photo counter-clockwise 90 degrees.</summary>
    Rotate90,
  }
}
