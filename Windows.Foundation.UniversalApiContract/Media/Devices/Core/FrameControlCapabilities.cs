// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameControlCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Provides information about the variable photo sequence capabilities of the capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class FrameControlCapabilities : 
    IFrameControlCapabilities,
    IFrameControlCapabilities2
  {
    /// <summary>Gets the exposure capabilities of the capture device for variable photo sequences.</summary>
    /// <returns>The exposure capabilities of the capture device for variable photo sequences.</returns>
    public extern FrameExposureCapabilities Exposure { [MethodImpl] get; }

    /// <summary>Gets the exposure compensation capabilities of the capture device for variable photo sequences.</summary>
    /// <returns>The exposure capabilities of the capture device for variable photo sequences.</returns>
    public extern FrameExposureCompensationCapabilities ExposureCompensation { [MethodImpl] get; }

    /// <summary>Gets the ISO speed capabilities of the capture device for variable photo sequences.</summary>
    /// <returns>The ISO speed capabilities of the capture device for variable photo sequences.</returns>
    public extern FrameIsoSpeedCapabilities IsoSpeed { [MethodImpl] get; }

    /// <summary>Gets the focus capabilities of the capture device for variable photo sequences.</summary>
    /// <returns>The focus capabilities of the capture device for variable photo sequences.</returns>
    public extern FrameFocusCapabilities Focus { [MethodImpl] get; }

    /// <summary>Gets whether the capture device supports photo confirmation for variable photo sequences.</summary>
    /// <returns>Whether the capture device supports photo confirmation for variable photo sequences.</returns>
    public extern bool PhotoConfirmationSupported { [MethodImpl] get; }

    /// <summary>Gets the flash capabilities of the capture device for variable photo sequences.</summary>
    /// <returns>The flash capabilities of the capture device for variable photo sequences.</returns>
    public extern FrameFlashCapabilities Flash { [MethodImpl] get; }
  }
}
