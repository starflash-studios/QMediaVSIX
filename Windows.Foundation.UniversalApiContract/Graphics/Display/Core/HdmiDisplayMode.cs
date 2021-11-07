// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  /// <summary>Represents the display mode of a connected device such as a TV or a monitor. It provides info about the display capabilities of the device, such as the number of bits per pixel, colorspace, type of pixel encoding, refresh rate, and more.</summary>
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HdmiDisplayMode : IHdmiDisplayMode, IHdmiDisplayMode2
  {
    /// <summary>Gets the device's resolution width in raw pixels.</summary>
    /// <returns>
    /// </returns>
    public extern uint ResolutionWidthInRawPixels { [MethodImpl] get; }

    /// <summary>Gets the device's resolution height in raw pixels.</summary>
    /// <returns>
    /// </returns>
    public extern uint ResolutionHeightInRawPixels { [MethodImpl] get; }

    /// <summary>Gets the device's refresh rate, in Hertz (Hz).</summary>
    /// <returns>
    /// </returns>
    public extern double RefreshRate { [MethodImpl] get; }

    /// <summary>Gets the value that indicates whether stereoscorpic 3D is enabled on the device.</summary>
    /// <returns>
    /// </returns>
    public extern bool StereoEnabled { [MethodImpl] get; }

    /// <summary>Gets the number of bits per pixel. It specifies the number of bits used in a pixel.</summary>
    /// <returns>
    /// </returns>
    public extern ushort BitsPerPixel { [MethodImpl] get; }

    /// <summary>Checks to see whether the current display mode is equal to a specific display mode.</summary>
    /// <param name="mode">
    /// </param>
    /// <returns>Value that indicates if the current display mode is equal to a specifc display mode. If TRUE, they are the equal.</returns>
    [MethodImpl]
    public extern bool IsEqual(HdmiDisplayMode mode);

    /// <summary>Gets the color space.</summary>
    /// <returns>
    /// </returns>
    public extern HdmiDisplayColorSpace ColorSpace { [MethodImpl] get; }

    /// <summary>Gets the type of pixel encoding the device uses for rendering display content.</summary>
    /// <returns>
    /// </returns>
    public extern HdmiDisplayPixelEncoding PixelEncoding { [MethodImpl] get; }

    /// <summary>Gets the value that indicates whether standard dynamic range (SDR) luminance levels are supported by the device.</summary>
    /// <returns>
    /// </returns>
    public extern bool IsSdrLuminanceSupported { [MethodImpl] get; }

    /// <summary>Gets the value that indicates whether the SMPTE (Society of Motion Picture and Television Engineers) ST 2084 electo-optical transfer function (EOTF) is supported.</summary>
    /// <returns>
    /// </returns>
    public extern bool IsSmpte2084Supported { [MethodImpl] get; }

    /// <summary>Indicates whether 10 bit display metadata is supported on the device.</summary>
    /// <returns>`true` if 10 bit display metadata is supported on the device, otherwise `false`.</returns>
    public extern bool Is2086MetadataSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the low-latency profile for Dolby Vision is supported on the device.</summary>
    /// <returns>`true` if the low-latency profile for Dolby Vision is supported on the device, otherwise `false`.</returns>
    public extern bool IsDolbyVisionLowLatencySupported { [MethodImpl] get; }
  }
}
