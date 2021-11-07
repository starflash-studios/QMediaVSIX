// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Contains transformations that can be applied to pixel data.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BitmapTransform : IBitmapTransform
  {
    /// <summary>Creates a new BitmapTransform object.</summary>
    [MethodImpl]
    public extern BitmapTransform();

    /// <summary>Specifies the width, in pixels, of the bitmap after it is scaled. This is defined in the coordinate space of the source image, before rotation and flip are applied.</summary>
    /// <returns>The width of the bitmap, in pixels.</returns>
    public extern uint ScaledWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the height, in pixels, of the bitmap after it is scaled. This is defined in the coordinate space of the source image, before rotation and flip are applied.</summary>
    /// <returns>The height of the bitmap, in pixels.</returns>
    public extern uint ScaledHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the interpolation mode that is used to scale the bitmap.</summary>
    /// <returns>The interpolation mode. One of the values of the BitmapInterpolationMode enumeration.</returns>
    public extern BitmapInterpolationMode InterpolationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the flip operation that is used to transform the bitmap.</summary>
    /// <returns>The type of flip operation. One of the values of the BitmapFlip enumeration.</returns>
    public extern BitmapFlip Flip { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the rotation operation that is used to transform the bitmap.</summary>
    /// <returns>The type of rotation. One of the values of the BitmapRotation enumeration.</returns>
    public extern BitmapRotation Rotation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the bounding rectangle that is used to crop the bitmap. This rectangle is defined in the coordinate space after scale, rotation, and flip are applied.</summary>
    /// <returns>A structure that specifies the bounding rectangle.</returns>
    public extern BitmapBounds Bounds { [MethodImpl] get; [MethodImpl] set; }
  }
}
