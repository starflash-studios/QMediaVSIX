// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameFlashControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Represents the flash settings for a frame in a variable photo sequence.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FrameFlashControl : IFrameFlashControl
  {
    /// <summary>Gets or sets the flash mode for a frame in a variable photo sequence.</summary>
    /// <returns>The flash mode.</returns>
    public extern FrameFlashMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether flash settings are automatically set for a frame in a variable photo sequence.</summary>
    /// <returns>True if the flash settings are automatically set for a frame in a variable photo sequence; otherwise, false.</returns>
    public extern bool Auto { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating if red eye reduction is enabled for a frame in a variable photo sequence.</summary>
    /// <returns>True if red eye reduction is enabled; otherwise, false.</returns>
    public extern bool RedEyeReduction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the flash power for a frame in a variable photo sequence.</summary>
    /// <returns>The flash power percentage, from 0 to 100, for a frame in a variable photo sequence.</returns>
    public extern float PowerPercent { [MethodImpl] get; [MethodImpl] set; }
  }
}
