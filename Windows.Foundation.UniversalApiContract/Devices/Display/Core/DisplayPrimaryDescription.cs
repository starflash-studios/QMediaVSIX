// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayPrimaryDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Devices.Display.Core
{
  /// <summary>Describes a set of properties that are used for allocating DisplaySurface objects using CreatePrimary.</summary>
  [Static(typeof (IDisplayPrimaryDescriptionStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Activatable(typeof (IDisplayPrimaryDescriptionFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayPrimaryDescription : IDisplayPrimaryDescription
  {
    /// <summary>Creates a primary description with the specified standard properties.</summary>
    /// <param name="width">
    /// </param>
    /// <param name="height">
    /// </param>
    /// <param name="pixelFormat">
    /// </param>
    /// <param name="colorSpace">
    /// </param>
    /// <param name="isStereo">
    /// </param>
    /// <param name="multisampleDescription">
    /// </param>
    [MethodImpl]
    public extern DisplayPrimaryDescription(
      uint width,
      uint height,
      DirectXPixelFormat pixelFormat,
      DirectXColorSpace colorSpace,
      bool isStereo,
      Direct3DMultisampleDescription multisampleDescription);

    /// <summary>Gets the width of a surface.</summary>
    /// <returns>A value containing the width of a surface.</returns>
    public extern uint Width { [MethodImpl] get; }

    /// <summary>Gets the height of a surface.</summary>
    /// <returns>A value containing the height of a surface.</returns>
    public extern uint Height { [MethodImpl] get; }

    /// <summary>Gets the DXGI-compatible format of a surface.</summary>
    /// <returns>A DirectXPixelFormat value.</returns>
    public extern DirectXPixelFormat Format { [MethodImpl] get; }

    /// <summary>Gets the DXGI-compatible color space of a surface.</summary>
    /// <returns>A DirectXColorSpace value.</returns>
    public extern DirectXColorSpace ColorSpace { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the description is of a stereoscopic 3D surface.</summary>
    /// <returns>`true` if the description is of a stereoscopic 3D surface, otherwise `false`.</returns>
    public extern bool IsStereo { [MethodImpl] get; }

    /// <summary>Gets the multisampling properties of a surface.</summary>
    /// <returns>A Direct3DMultisampleDescription value specifying the multisampling properties of a surface.</returns>
    public extern Direct3DMultisampleDescription MultisampleDescription { [MethodImpl] get; }

    /// <summary>Reserved for future use.</summary>
    /// <returns>
    /// </returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    [MethodImpl]
    public static extern DisplayPrimaryDescription CreateWithProperties(
      IIterable<IKeyValuePair<Guid, object>> extraProperties,
      uint width,
      uint height,
      DirectXPixelFormat pixelFormat,
      DirectXColorSpace colorSpace,
      bool isStereo,
      Direct3DMultisampleDescription multisampleDescription);
  }
}
