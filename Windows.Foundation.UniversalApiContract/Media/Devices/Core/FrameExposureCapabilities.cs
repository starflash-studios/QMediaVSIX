// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameExposureCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Provides information about the exposure time capabilities of the capture device for frames in a variable photo sequences.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class FrameExposureCapabilities : IFrameExposureCapabilities
  {
    /// <summary>Gets a value that indicates if the capture device supports the exposure control for variable photo sequences.</summary>
    /// <returns>True if the capture device supports the exposure control; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the minimum exposure time supported by the capture device.</summary>
    /// <returns>Gets the minimum exposure time supported by the capture device.</returns>
    public extern TimeSpan Min { [MethodImpl] get; }

    /// <summary>Gets the maximum exposure time supported by the capture device.</summary>
    /// <returns>The maximum exposure time supported by the capture device.</returns>
    public extern TimeSpan Max { [MethodImpl] get; }

    /// <summary>Gets the smallest exposure time increment supported by the capture device.</summary>
    /// <returns>Gets the smallest exposure time increment supported by the capture device.</returns>
    public extern TimeSpan Step { [MethodImpl] get; }
  }
}
