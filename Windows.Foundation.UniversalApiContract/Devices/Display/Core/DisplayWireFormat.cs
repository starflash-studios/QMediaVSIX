// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayWireFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Specifies an exact hardware representation used to scan out; such as the pixel encoding, bits per channel, color space, and HDR metadata format.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDisplayWireFormatStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Activatable(typeof (IDisplayWireFormatFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class DisplayWireFormat : IDisplayWireFormat
  {
    /// <summary>Constructs a DisplayWireFormat object from the supplied property values.</summary>
    /// <param name="pixelEncoding">Describes how pixels are encoded by the display pipeline, including chroma subsampling.</param>
    /// <param name="bitsPerChannel">The number of bits used for each channel, without regard for chroma subsampling.</param>
    /// <param name="colorSpace">Describes the color space.</param>
    /// <param name="eotf">Specifies the electro-optical transfer function (EOTF) that pixels are encoded for.</param>
    /// <param name="hdrMetadata">Specifies the format for static or dynamic HDR mastering metadata.</param>
    [MethodImpl]
    public extern DisplayWireFormat(
      DisplayWireFormatPixelEncoding pixelEncoding,
      int bitsPerChannel,
      DisplayWireFormatColorSpace colorSpace,
      DisplayWireFormatEotf eotf,
      DisplayWireFormatHdrMetadata hdrMetadata);

    /// <summary>Describes how pixels are encoded by the display pipeline, including chroma subsampling.</summary>
    /// <returns>
    /// </returns>
    public extern DisplayWireFormatPixelEncoding PixelEncoding { [MethodImpl] get; }

    /// <summary>Gets the number of bits used for each channel, without regard for chroma subsampling.</summary>
    /// <returns>A value containing the number of bits used for each channel, without regard for chroma subsampling.</returns>
    public extern int BitsPerChannel { [MethodImpl] get; }

    /// <summary>Gets the color format.</summary>
    /// <returns>A DisplayWireFormatColorSpace value.</returns>
    public extern DisplayWireFormatColorSpace ColorSpace { [MethodImpl] get; }

    /// <summary>Specifies the electro-optical transfer function (EOTF) that pixels are encoded for.</summary>
    /// <returns>
    /// </returns>
    public extern DisplayWireFormatEotf Eotf { [MethodImpl] get; }

    /// <summary>Specifies the format for static or dynamic HDR mastering metadata.</summary>
    /// <returns>
    /// </returns>
    public extern DisplayWireFormatHdrMetadata HdrMetadata { [MethodImpl] get; }

    /// <summary>Reserved for future use.</summary>
    /// <returns>
    /// </returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    [MethodImpl]
    public static extern DisplayWireFormat CreateWithProperties(
      IIterable<IKeyValuePair<Guid, object>> extraProperties,
      DisplayWireFormatPixelEncoding pixelEncoding,
      int bitsPerChannel,
      DisplayWireFormatColorSpace colorSpace,
      DisplayWireFormatEotf eotf,
      DisplayWireFormatHdrMetadata hdrMetadata);
  }
}
