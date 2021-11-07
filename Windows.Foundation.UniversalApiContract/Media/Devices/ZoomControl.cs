// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ZoomControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the zoom settings on a capture device.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 167772160)]
  public sealed class ZoomControl : IZoomControl, IZoomControl2
  {
    /// <summary>Gets a value indicating whether zoom control is supported by the capture device.</summary>
    /// <returns>A value indicating whether zoom control is supported by the capture device.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the minimum zoom value supported by the capture device.</summary>
    /// <returns>The minimum zoom value supported by the capture device.</returns>
    public extern float Min { [MethodImpl] get; }

    /// <summary>Gets the maximum zoom value supported by the capture device.</summary>
    /// <returns>The maximum zoom value supported by the capture device.</returns>
    public extern float Max { [MethodImpl] get; }

    /// <summary>Gets the smallest zoom value increment supported by the capture device.</summary>
    /// <returns>The smallest zoom value increment supported by the capture device.</returns>
    public extern float Step { [MethodImpl] get; }

    /// <summary>Gets or sets the zoom value to be used by the capture device.</summary>
    /// <returns>The zoom value to be used by the capture device.</returns>
    public extern float Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of ZoomTransitionMode values indicating the modes supported by the capture device.</summary>
    /// <returns>The list of supported ZoomTransitionMode values.</returns>
    public extern IVectorView<ZoomTransitionMode> SupportedModes { [MethodImpl] get; }

    /// <summary>Gets a value indicating the current zoom transition mode.</summary>
    /// <returns>A value indicating the current zoom transition mode.</returns>
    public extern ZoomTransitionMode Mode { [MethodImpl] get; }

    /// <summary>Configures the zoom control with the provided zoom settings.</summary>
    /// <param name="settings">The zoom settings.</param>
    [MethodImpl]
    public extern void Configure(ZoomSettings settings);
  }
}
