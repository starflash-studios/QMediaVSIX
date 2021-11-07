// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicDisplay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  /// <summary>Provides metadata for a display to which a holographic view must render each frame from that frame's pose.</summary>
  [Static(typeof (IHolographicDisplayStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class HolographicDisplay : 
    IHolographicDisplay,
    IHolographicDisplay2,
    IHolographicDisplay3
  {
    /// <summary>Gets a friendly name for this display that can be displayed to the user.</summary>
    /// <returns>The friendly name.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the maximum viewport size that an app will ever be asked to render to for this display.</summary>
    /// <returns>The maximum viewport size.</returns>
    public extern Size MaxViewportSize { [MethodImpl] get; }

    /// <summary>Gets whether this display requires separate rendering for the left and right eyes.</summary>
    /// <returns>Whether this display is stereo.</returns>
    public extern bool IsStereo { [MethodImpl] get; }

    /// <summary>Gets whether this display is occluded, blocking the user's view of the physical world around them.</summary>
    /// <returns>Whether this display is occluded.</returns>
    public extern bool IsOpaque { [MethodImpl] get; }

    /// <summary>Gets the identifier of the graphics adapter to be used when displaying holographic content to this HolographicDisplay.</summary>
    /// <returns>The identifier.</returns>
    public extern HolographicAdapterId AdapterId { [MethodImpl] get; }

    /// <summary>Gets a spatial locator that can be used to create frames of reference relative to this display.</summary>
    /// <returns>The spatial locator.</returns>
    public extern SpatialLocator SpatialLocator { [MethodImpl] get; }

    /// <summary>Gets the refresh rate at which an app must present content to this holographic display.</summary>
    /// <returns>The refresh rate.</returns>
    public extern double RefreshRate { [MethodImpl] get; }

    /// <summary>Attempts to retrieve the view configuration for this HolographicDisplay, which corresponds to the supplied HolographicViewConfigurationKind.</summary>
    /// <param name="kind">A HolographicViewConfigurationKind indicating the kind of view configuration to be retrieved.</param>
    /// <returns>A HolographicViewConfiguration object of the indicated kind, or null if the HolographicDisplay does not support the indicated HolographicViewConfigurationKind.</returns>
    [MethodImpl]
    public extern HolographicViewConfiguration TryGetViewConfiguration(
      HolographicViewConfigurationKind kind);

    /// <summary>Gets the default display that represents the user's primary Mixed Reality headset.</summary>
    /// <returns>The default display.</returns>
    [MethodImpl]
    public static extern HolographicDisplay GetDefault();
  }
}
