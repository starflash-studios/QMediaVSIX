// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Haptics;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents the specifics of a motion controller.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialInteractionController : 
    ISpatialInteractionController,
    ISpatialInteractionController2,
    ISpatialInteractionController3
  {
    /// <summary>Gets whether the motion controller has a touchpad.</summary>
    /// <returns>Whether the controller has a touchpad.</returns>
    public extern bool HasTouchpad { [MethodImpl] get; }

    /// <summary>Gets whether the motion controller has a thumbstick.</summary>
    /// <returns>Whether the controller has a thumbstick.</returns>
    public extern bool HasThumbstick { [MethodImpl] get; }

    /// <summary>Provides access to the motion controller's ability to vibrate in the user's hand.</summary>
    /// <returns>The simple haptics controller.</returns>
    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }

    /// <summary>Gets the vendor identifier for this motion controller.</summary>
    /// <returns>The vendor identifier.</returns>
    public extern ushort VendorId { [MethodImpl] get; }

    /// <summary>Gets the product identifier for this motion controller.</summary>
    /// <returns>The product identifier.</returns>
    public extern ushort ProductId { [MethodImpl] get; }

    /// <summary>Gets the version, or revision, number for this motion controller.</summary>
    /// <returns>The version number.</returns>
    public extern ushort Version { [MethodImpl] get; }

    /// <summary>Gets a renderable model stream for this controller, which can be unpacked and rendered to represent this controller.</summary>
    /// <returns>Operation that triggers once the renderable model stream is loaded, yielding the stream or null if there is no model available.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> TryGetRenderableModelAsync();

    /// <summary>Gets information about the motion controller's current battery state.</summary>
    /// <returns>Information about the motion controller's current battery state, if available; otherwise, null.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();
  }
}
