// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapInterpolationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the interpolation mode used for scaling pixel data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BitmapInterpolationMode
  {
    /// <summary>A nearest neighbor interpolation algorithm. Also known as nearest pixel or point interpolation. The output pixel is assigned the value of the pixel that the point falls within. No other pixels are considered.</summary>
    NearestNeighbor,
    /// <summary>A bilinear interpolation algorithm. The output pixel values are computed as a weighted average of the nearest four pixels in a 2x2 grid.</summary>
    Linear,
    /// <summary>A bicubic interpolation algorithm. Destination pixel values are computed as a weighted average of the nearest sixteen pixels in a 4x4 grid.</summary>
    Cubic,
    /// <summary>A Fant resampling algorithm. Destination pixel values are computed as a weighted average of the all the pixels that map to the new pixel in a box shaped kernel.</summary>
    Fant,
  }
}
