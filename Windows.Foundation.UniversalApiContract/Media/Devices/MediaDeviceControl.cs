// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaDeviceControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Gets or sets a device setting on a camera.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class MediaDeviceControl : IMediaDeviceControl
  {
    /// <summary>Gets the capabilities of the camera for this camera setting.</summary>
    /// <returns>The capabilities, including the supported range of values, the default value, and the step size.</returns>
    public extern MediaDeviceControlCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Gets the value of the camera setting.</summary>
    /// <param name="value">The current value of the setting. The units depend on the setting.</param>
    /// <returns>Returns true if the method succeeds, or false otherwise.</returns>
    [MethodImpl]
    public extern bool TryGetValue(out double value);

    /// <summary>Sets the camera setting.</summary>
    /// <param name="value">The new value of the camera setting. The units depend on the setting.</param>
    /// <returns>Returns true if the method succeeds, or false otherwise.</returns>
    [MethodImpl]
    public extern bool TrySetValue(double value);

    /// <summary>Indicates whether automatic adjustment of the camera setting is enabled.</summary>
    /// <param name="value">True if automatic adjustment is enabled; false otherwise.</param>
    /// <returns>Returns true if the method succeeds, or false otherwise.</returns>
    [MethodImpl]
    public extern bool TryGetAuto(out bool value);

    /// <summary>Enables or disables automatic adjustment of the camera setting.</summary>
    /// <param name="value">True to enable automatic adjustment; or false to disable automatic adjustment. If false, call TrySetValue to adjust the setting.</param>
    /// <returns>Returns true if the method succeeds, or false otherwise.</returns>
    [MethodImpl]
    public extern bool TrySetAuto(bool value);
  }
}
