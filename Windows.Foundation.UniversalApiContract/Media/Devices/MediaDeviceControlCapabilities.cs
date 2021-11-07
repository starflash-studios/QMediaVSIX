// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaDeviceControlCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Gets the capabilities of a camera setting.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 100794368)]
  public sealed class MediaDeviceControlCapabilities : IMediaDeviceControlCapabilities
  {
    /// <summary>Indicates whether the camera supports this camera setting.</summary>
    /// <returns>True if the camera supports the setting; otherwise false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the minimum value of the camera setting.</summary>
    /// <returns>The minimum value.</returns>
    public extern double Min { [MethodImpl] get; }

    /// <summary>Sets the maximum value of the camera setting.</summary>
    /// <returns>The maximum value.</returns>
    public extern double Max { [MethodImpl] get; }

    /// <summary>Ges the step size for the setting. The step size is the smallest increment by which the property can change.</summary>
    /// <returns>The step size.</returns>
    public extern double Step { [MethodImpl] get; }

    /// <summary>Gets the default value of the camera setting.</summary>
    /// <returns>The default value.</returns>
    public extern double Default { [MethodImpl] get; }

    /// <summary>Queries whether the camera supports automatic adjustment of the setting.</summary>
    /// <returns>True if the camera supports automatic adjustment of the setting; otherwise false.</returns>
    public extern bool AutoModeSupported { [MethodImpl] get; }
  }
}
