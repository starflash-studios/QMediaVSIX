// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameIsoSpeedCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Provides information about the ISO speed capabilities of the capture device for frames in a variable photo sequences.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  public sealed class FrameIsoSpeedCapabilities : IFrameIsoSpeedCapabilities
  {
    /// <summary>Gets a value that indicates if the capture device supports the ISO speed control for frames in a variable photo sequence.</summary>
    /// <returns>True if the capture device supports the ISO speed control; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>The minimum ISO speed supported by the capture device for a frame in a variable photo sequence.</summary>
    /// <returns>The minimum ISO speed supported by the capture device for a frame in a variable photo sequence.</returns>
    public extern uint Min { [MethodImpl] get; }

    /// <summary>Gets the maximum ISO speed supported by the capture device for a frame in a variable photo sequence.</summary>
    /// <returns>The maximum ISO speed supported by the capture device for a frame in a variable photo sequence.</returns>
    public extern uint Max { [MethodImpl] get; }

    /// <summary>Gets the smallest ISO speed increment supported by the capture device for a frame in a variable photo sequence, specified in millimeters.</summary>
    /// <returns>The smallest ISO speed increment supported by the capture device for a frame in a variable photo sequence, specified in millimeters.</returns>
    public extern uint Step { [MethodImpl] get; }
  }
}
