// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayPath
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
  /// <summary>Represents a display pipeline path from a logical "source" to a DisplayTarget. A logical source provides a frame buffer, in a format described by the source properties. The display pipeline composes the source content and transforms it into the format described by the target properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayPath : IDisplayPath, IDisplayPath2
  {
    /// <summary>Gets the logical view that this path is connected from. All paths residing in the same DisplayView are logically cloned together.</summary>
    /// <returns>A DisplayView value.</returns>
    public extern DisplayView View { [MethodImpl] get; }

    /// <summary>The DisplayTarget that this path connects to.</summary>
    /// <returns>A DisplayTarget value.</returns>
    public extern DisplayTarget Target { [MethodImpl] get; }

    /// <summary>Gets the last status of the path in the system, captured when the DisplayState was last created or applied.</summary>
    /// <returns>A DisplayPathStatus value.</returns>
    public extern DisplayPathStatus Status { [MethodImpl] get; }

    /// <summary>Gets or sets an optional value for the size of the pixel buffer used for scanout, before it is transformed to fit into the target resolution.</summary>
    /// <returns>A value indicating the size of the pixel buffer used for scanout.</returns>
    public extern IReference<SizeInt32> SourceResolution { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the pixel format of the surfaces that will be allowed to present to this DisplayPath.</summary>
    /// <returns>A DirectXPixelFormat value.</returns>
    public extern DirectXPixelFormat SourcePixelFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the target mode for this path is in 3D stereoscopic mode.</summary>
    /// <returns>`true` if the target mode for this path is in 3D stereoscopic mode, otherwise `false`.</returns>
    public extern bool IsStereo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an optional value for the size of the frame provided to the target's monitor. This can differ from the size of the "source" frame buffer, in which case the display pipeline transforms the content using the Rotation and Scaling properties.</summary>
    /// <returns>A value indicating the size of the frame provided to the target's monitor.</returns>
    public extern IReference<SizeInt32> TargetResolution { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an optional value for the refresh rate, also known as the vertical sync rate, of this path's target mode.</summary>
    /// <returns>A DisplayPresentationRate value.</returns>
    public extern IReference<DisplayPresentationRate> PresentationRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an optional value for whether the target mode for this path is interlaced.</summary>
    /// <returns>`true` if the target mode for this path is interlaced, otherwise `false`.</returns>
    public extern IReference<bool> IsInterlaced { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an optional value for the exact hardware representation used to scan out; such as the pixel encoding, bits per channel, color space, and HDR metadata format.</summary>
    /// <returns>A DisplayWireFormat value.</returns>
    public extern DisplayWireFormat WireFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how the display pipeline rotates the source frame buffer before scanning out to the target.</summary>
    /// <returns>A DisplayRotation value.</returns>
    public extern DisplayRotation Rotation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how the display pipeline scales the source frame buffer before scanning out to the target.</summary>
    /// <returns>A DisplayPathScaling value.</returns>
    public extern DisplayPathScaling Scaling { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Queries the driver to determine the valid mode combinations that can be applied to this DisplayPath. Any properties that have already been set on this path are used as constraints to limit the set of modes returned.</summary>
    /// <param name="flags">A DisplayModeQueryOptions value containing extended options for filtering the resulting modes.</param>
    /// <returns>A collection containing zero or more modes that the driver reports could be successfully applied to this path. If the collection is empty, then either the driver doesn't support applying the DisplayState, or the supplied options are too constraining.</returns>
    [MethodImpl]
    public extern IVectorView<DisplayModeInfo> FindModes(
      DisplayModeQueryOptions flags);

    /// <summary>Sets on this DisplayPath object all properties reflected in a supplied DisplayModeInfo. Note that the wire format is not set by this method, since a **DisplayModeInfo** object refers to a range of valid wire formats.</summary>
    /// <param name="modeResult">A DisplayModeInfo reflecting the properties to set.</param>
    [MethodImpl]
    public extern void ApplyPropertiesFromMode(DisplayModeInfo modeResult);

    /// <summary>Reserved for future use.</summary>
    /// <returns>Reserved for future use.</returns>
    public extern IMap<Guid, object> Properties { [MethodImpl] get; }

    public extern IReference<DisplayPresentationRate> PhysicalPresentationRate { [MethodImpl] get; [MethodImpl] set; }
  }
}
