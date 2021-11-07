// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display.Core
{
  /// <summary>Represents a context for creating and presenting content directly to the display driver. A **DisplayDevice** is analogous to a Direct3D device in the Direct3D API.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayDevice : IDisplayDevice, IDisplayDevice2
  {
    /// <summary>Creates a DisplaySource object, which provides the ability to directly scan out/present to the DisplayTarget object or objects currently connected to this source.</summary>
    /// <param name="target">An active DisplayTarget for which to create a display source.</param>
    /// <returns>A DisplaySource value.</returns>
    [MethodImpl]
    public extern DisplaySource CreateScanoutSource(DisplayTarget target);

    /// <summary>Creates a primary surface (or just "primary") for use with the display controller. The resulting primary surface is compatible with a DisplayScanout, which is used for presenting content directly to the screen.</summary>
    /// <param name="target">An active DisplayTarget, which is used to determine which source the primary will be optimized for.</param>
    /// <param name="desc">A description of the primary surface to create, such as width, height, and pixel format.</param>
    /// <returns>A DisplaySurface value.</returns>
    [MethodImpl]
    public extern DisplaySurface CreatePrimary(
      DisplayTarget target,
      DisplayPrimaryDescription desc);

    /// <summary>Creates a DisplayTaskPool, which can create and execute DisplayTask objects on this DisplayDevice.</summary>
    /// <returns>A DisplayTaskPool value.</returns>
    [MethodImpl]
    public extern DisplayTaskPool CreateTaskPool();

    [MethodImpl]
    public extern DisplayFence CreatePeriodicFence(
      DisplayTarget target,
      TimeSpan offsetFromVBlank);

    /// <summary>Synchronously waits for the next V-blank interrupt to be fired by the primary DisplayTarget for a given DisplaySource.</summary>
    /// <param name="source">The DisplaySource whose primary display target's V-blank interrupt to wait for.</param>
    [MethodImpl]
    public extern void WaitForVBlank(DisplaySource source);

    /// <summary>Creates a DisplayScanout object, which can be used to present a full-screen surface directly to the screen.</summary>
    /// <param name="pSource">A DisplaySource to present full-screen content to.</param>
    /// <param name="pSurface">A full-screen primary surface.</param>
    /// <param name="SubResourceIndex">
    /// </param>
    /// <param name="SyncInterval">
    /// </param>
    /// <returns>A DisplayScanout value.</returns>
    [MethodImpl]
    public extern DisplayScanout CreateSimpleScanout(
      DisplaySource pSource,
      DisplaySurface pSurface,
      uint SubResourceIndex,
      uint SyncInterval);

    /// <summary>Retrieves a Boolean value indicating whether or not a given capability is supported by this DisplayDevice.</summary>
    /// <param name="capability">The DisplayDeviceCapability to query about.</param>
    /// <returns>`true` if the capability is supported, otherwise `false`.</returns>
    [MethodImpl]
    public extern bool IsCapabilitySupported(DisplayDeviceCapability capability);

    [MethodImpl]
    public extern DisplayScanout CreateSimpleScanoutWithDirtyRectsAndOptions(
      DisplaySource source,
      DisplaySurface surface,
      uint subresourceIndex,
      uint syncInterval,
      IIterable<RectInt32> dirtyRects,
      DisplayScanoutOptions options);
  }
}
