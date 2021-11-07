// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.ImageEncodingProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes the format of an image stream.</summary>
  [Static(typeof (IImageEncodingPropertiesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IImageEncodingPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IImageEncodingPropertiesStatics3), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class ImageEncodingProperties : 
    IImageEncodingProperties,
    IMediaEncodingProperties,
    IImageEncodingProperties2
  {
    /// <summary>Creates a new instance of the ImageEncodingProperties class.</summary>
    [MethodImpl]
    public extern ImageEncodingProperties();

    /// <summary>Gets or sets the image width.</summary>
    /// <returns>The width of the image, in pixels.</returns>
    public extern uint Width { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the image height.</summary>
    /// <returns>The height of the image, in pixels.</returns>
    public extern uint Height { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets additional format properties for the image stream.</summary>
    /// <returns>A property set that contains format properties.</returns>
    public extern MediaPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets the format type.</summary>
    /// <returns>The format type. For image streams, the format type is "Image".</returns>
    public extern string Type { [MethodImpl] get; }

    /// <summary>Gets or sets the subtype of the format.</summary>
    /// <returns>The subtype.</returns>
    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Creates a copy of the **ImageEncodingProperties** object.</summary>
    /// <returns>A copy of the **ImageEncodingProperties** object.</returns>
    [MethodImpl]
    public extern ImageEncodingProperties Copy();

    /// <summary>Creates an instance of ImageEncodingProperties for HEIF format.</summary>
    /// <returns>The ImageEncodingProperties for HEIF format.</returns>
    [MethodImpl]
    public static extern ImageEncodingProperties CreateHeif();

    /// <summary>Creates an instance of ImageEncodingProperties for an uncompressed image.</summary>
    /// <param name="format">The media pixel format.</param>
    /// <returns>The image encoding properties.</returns>
    [MethodImpl]
    public static extern ImageEncodingProperties CreateUncompressed(
      MediaPixelFormat format);

    /// <summary>Creates an instance of ImageEncodingProperties for a BMP image.</summary>
    /// <returns>The image encoding properties.</returns>
    [MethodImpl]
    public static extern ImageEncodingProperties CreateBmp();

    /// <summary>Creates an instance of ImageEncodingProperties for a JPEG image.</summary>
    /// <returns>The properties for the image stream.</returns>
    [MethodImpl]
    public static extern ImageEncodingProperties CreateJpeg();

    /// <summary>Creates an instance of ImageEncodingProperties for a PNG image.</summary>
    /// <returns>The properties for the image stream.</returns>
    [MethodImpl]
    public static extern ImageEncodingProperties CreatePng();

    /// <summary>Creates an instance of ImageEncodingProperties for a JPEG XR image.</summary>
    /// <returns>The properties for the image stream.</returns>
    [MethodImpl]
    public static extern ImageEncodingProperties CreateJpegXR();
  }
}
