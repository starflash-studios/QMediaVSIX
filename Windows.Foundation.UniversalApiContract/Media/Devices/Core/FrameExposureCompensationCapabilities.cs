// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameExposureCompensationCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Provides information about the exposure compensation capabilities of the capture device for frames in a variable photo sequences.</summary>
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FrameExposureCompensationCapabilities : IFrameExposureCompensationCapabilities
  {
    /// <summary>Gets a value that indicates if the capture device supports the frame exposure compensation control for frames in a variable photo sequence.</summary>
    /// <returns>True if the capture device supports the frame exposure control; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the minimum exposure compensation supported by the capture device.</summary>
    /// <returns>The minimum exposure compensation supported by the capture device.</returns>
    public extern float Min { [MethodImpl] get; }

    /// <summary>Gets the maximum exposure compensation supported by the capture device.</summary>
    /// <returns>The maximum exposure compensation supported by the capture device.</returns>
    public extern float Max { [MethodImpl] get; }

    /// <summary>Gets the smallest exposure time compensation increment supported by the capture device.</summary>
    /// <returns>The smallest exposure time compensation increment supported by the capture device.</returns>
    public extern float Step { [MethodImpl] get; }
  }
}
