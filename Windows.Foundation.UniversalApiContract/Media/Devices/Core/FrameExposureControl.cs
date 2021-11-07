// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameExposureControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Represents the exposure time settings for a frame in a variable photo sequence.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class FrameExposureControl : IFrameExposureControl
  {
    /// <summary>Gets or sets a value indicating whether auto exposure is enabled for a frame in a variable photo sequence.</summary>
    /// <returns>A value indicating whether auto exposure is enabled for a frame in a variable photo sequence.</returns>
    public extern bool Auto { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the exposure time for a frame in a variable photo sequence.</summary>
    /// <returns>The exposure time for a frame in a variable photo sequence.</returns>
    public extern IReference<TimeSpan> Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
