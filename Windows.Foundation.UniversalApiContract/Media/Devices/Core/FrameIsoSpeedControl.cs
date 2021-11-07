// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameIsoSpeedControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Represents the ISO speed settings for a frame in a variable photo sequence.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class FrameIsoSpeedControl : IFrameIsoSpeedControl
  {
    /// <summary>Gets or sets a value indicating whether ISO speed is automatically set for a frame in a variable photo sequence.</summary>
    /// <returns>True if the ISO speed is automatically set for a frame in a variable photo sequence; otherwise, false.</returns>
    public extern bool Auto { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ISO speed for a frame in a variable photo sequence.</summary>
    /// <returns>The ISO speed for a frame in a variable photo sequence.</returns>
    public extern IReference<uint> Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
