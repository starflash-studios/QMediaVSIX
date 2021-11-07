// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayModeInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.Devices.Display.Core
{
  /// <summary>Describes valid combinations of properties for a DisplayPath. The property values on this object can be set on a **DisplayPath** using the ApplyPropertiesFromMode method. Note that this object refers to a range of valid wire formats, not just one specific wire format.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayModeInfo : IDisplayModeInfo, IDisplayModeInfo2
  {
    /// <summary>Gets or sets an optional value for the size of the pixel buffer used for scanout, before it is transformed to fit into the target resolution.</summary>
    /// <returns>A value indicating the size of the pixel buffer used for scanout.</returns>
    public extern SizeInt32 SourceResolution { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the DisplayModeInfo is stereoscopic 3D.</summary>
    /// <returns>`true` if this is a stereoscopic 3D DisplayModeInfo, otherwise `false`.</returns>
    public extern bool IsStereo { [MethodImpl] get; }

    /// <summary>Gets or sets the pixel format of the surfaces that will be allowed to present to this DisplayModeInfo.</summary>
    /// <returns>A DirectXPixelFormat value.</returns>
    public extern DirectXPixelFormat SourcePixelFormat { [MethodImpl] get; }

    /// <summary>Gets or sets an optional value for the size of the frame provided to the target's monitor. This can differ from the size of the "source" frame buffer, in which case the display pipeline transforms the content using the Rotation and Scaling properties.</summary>
    /// <returns>A value indicating the size of the frame provided to the target's monitor.</returns>
    public extern SizeInt32 TargetResolution { [MethodImpl] get; }

    /// <summary>Gets the presentation rate of the DisplayModeInfo.</summary>
    /// <returns>A DisplayPresentationRate value.</returns>
    public extern DisplayPresentationRate PresentationRate { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the DisplayModeInfo is interlaced.</summary>
    /// <returns>`true` if this is an interlaced DisplayModeInfo, otherwise `false`.</returns>
    public extern bool IsInterlaced { [MethodImpl] get; }

    /// <summary>Retrieves a value containing zero or more display bits-per-channel flags (logically OR-ed together) that are valid for the DisplayModeInfo, for a supplied display wire format pixel encoding.</summary>
    /// <param name="encoding">The desired DisplayWireFormatPixelEncoding for determining which bits-per-channel settings are valid.</param>
    /// <returns>A DisplayBitsPerChannel value containing zero or more display bits-per-channel flags (logically OR-ed together).</returns>
    [MethodImpl]
    public extern DisplayBitsPerChannel GetWireFormatSupportedBitsPerChannel(
      DisplayWireFormatPixelEncoding encoding);

    /// <summary>Retrieves a Boolean value indicating whether the DisplayModeInfo supports the specified format.</summary>
    /// <param name="wireFormat">A DisplayWireFormat.</param>
    /// <returns>`true` if the format is supported, otherwise `false`.</returns>
    [MethodImpl]
    public extern bool IsWireFormatSupported(DisplayWireFormat wireFormat);

    /// <summary>Gets a collection containing the properties of the DisplayModeInfo.</summary>
    /// <returns>An IMapView, keyed by **Guid**, of objects representing properties.</returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    public extern DisplayPresentationRate PhysicalPresentationRate { [MethodImpl] get; }
  }
}
