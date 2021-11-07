// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameFlashCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Provides information about the flash capabilities of the capture device for frames in a variable photo sequences.</summary>
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class FrameFlashCapabilities : IFrameFlashCapabilities
  {
    /// <summary>Gets a value that indicates if the capture device supports the flash control for frames in a variable photo sequence.</summary>
    /// <returns>True if the capture device supports the flash control; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether red eye reduction is supported for frames in a variable photo sequences.</summary>
    /// <returns>True if red eye reduction is supported; otherwise, false.</returns>
    public extern bool RedEyeReductionSupported { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether flash power is supported for frames in a variable photo sequences.</summary>
    /// <returns>True if flash power is supported; otherwise, false.</returns>
    public extern bool PowerSupported { [MethodImpl] get; }
  }
}
