// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicSpace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.UI.Core;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents a holographic scene, with one or more holographic cameras rendering its content.</summary>
  [Static(typeof (IHolographicSpaceStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IHolographicSpaceStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHolographicSpaceStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicSpace : IHolographicSpace, IHolographicSpace2, IHolographicSpace3
  {
    /// <summary>Gets the identifier of the graphics adapter to be used when displaying holographic content to the default HolographicDisplay.</summary>
    /// <returns>The identifier.</returns>
    public extern HolographicAdapterId PrimaryAdapterId { [MethodImpl] get; }

    /// <summary>Assigns the IDirect3DDevice that will display holographic content. An error will occur if the app creates an inappropriate device.</summary>
    /// <param name="value">The Direct3D device.</param>
    [MethodImpl]
    public extern void SetDirect3D11Device(IDirect3DDevice value);

    /// <summary>Occurs when a HolographicCamera is added to the current HolographicSpace.</summary>
    public extern event TypedEventHandler<HolographicSpace, HolographicSpaceCameraAddedEventArgs> CameraAdded;

    /// <summary>Occurs when a HolographicCamera is removed from the current HolographicSpace.</summary>
    public extern event TypedEventHandler<HolographicSpace, HolographicSpaceCameraRemovedEventArgs> CameraRemoved;

    /// <summary>Creates a HolographicFrame for the next frame to display.</summary>
    /// <returns>The next frame.</returns>
    [MethodImpl]
    public extern HolographicFrame CreateNextFrame();

    /// <summary>Describes whether the user is present within the headset to view and interact with this HolographicSpace.</summary>
    /// <returns>The user presence.</returns>
    public extern HolographicSpaceUserPresence UserPresence { [MethodImpl] get; }

    /// <summary>Occurs when the user's presence within the headset or ability to view and interact with this HolographicSpace changes.</summary>
    public extern event TypedEventHandler<HolographicSpace, object> UserPresenceChanged;

    /// <summary>Blocks the current thread until the right time to begin rendering the next frame.</summary>
    [MethodImpl]
    public extern void WaitForNextFrameReady();

    [MethodImpl]
    public extern void WaitForNextFrameReadyWithHeadStart(TimeSpan requestedHeadStartDuration);

    /// <summary>Creates an object to monitor an independent stream of frame presentation reports from this HolographicSpace.</summary>
    /// <deprecated type="deprecate">Use CreateFrameScanoutMonitor instead of CreateFramePresentationMonitor. For more info, see MSDN.</deprecated>
    /// <param name="maxQueuedReports">The maximum number of frame reports that can queue up without being read before reports are discarded.</param>
    /// <returns>The frame presentation monitor.</returns>
    [Deprecated("Use CreateFrameScanoutMonitor instead of CreateFramePresentationMonitor. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern HolographicFramePresentationMonitor CreateFramePresentationMonitor(
      uint maxQueuedReports);

    /// <summary>Creates a HolographicFrameScanoutMonitor that allows Windows Mixed Reality applications to monitor detailed performance and timing information about the platform in real time.</summary>
    /// <param name="maxQueuedReports">The maximum number of HolographicFrameScanoutReport objects that will be buffered by the system at any one time.</param>
    /// <returns>The created HolographicFrameScanoutMonitor.</returns>
    [MethodImpl]
    public extern HolographicFrameScanoutMonitor CreateFrameScanoutMonitor(
      uint maxQueuedReports);

    /// <summary>Gets whether the current system has been configured by the user for Mixed Reality headsets.</summary>
    /// <returns>Whether headsets are configured by the user.</returns>
    public static extern bool IsConfigured { [MethodImpl] get; }

    /// <summary>Gets whether the current system supports Mixed Reality headsets.</summary>
    /// <returns>Whether headsets are supported.</returns>
    public static extern bool IsSupported { [MethodImpl] get; }

    /// <summary>Gets whether a Mixed Reality headset is ready for holographic rendering.</summary>
    /// <returns>Whether a headset is ready.</returns>
    public static extern bool IsAvailable { [MethodImpl] get; }

    /// <summary>Occurs when a configured and ready Mixed Reality headset is attached or detached from the system.</summary>
    public static extern event EventHandler<object> IsAvailableChanged;

    /// <summary>Creates a HolographicSpace that corresponds with the specified window's CoreApplicationView.</summary>
    /// <param name="window">The window to create a HolographicSpace for.</param>
    /// <returns>The HolographicSpace.</returns>
    [MethodImpl]
    public static extern HolographicSpace CreateForCoreWindow(CoreWindow window);
  }
}
