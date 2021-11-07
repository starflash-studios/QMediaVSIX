// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.DepthMediaFrameFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Describes the format of a DepthMediaFrame.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DepthMediaFrameFormat : IDepthMediaFrameFormat
  {
    /// <summary>Gets the VideoMediaFrameFormat object that describes the non-depth-specific format of a DepthMediaFrame.</summary>
    /// <returns>The VideoMediaFrameFormat object that describes the non-depth-specific format of a DepthMediaFrame.</returns>
    public extern VideoMediaFrameFormat VideoFormat { [MethodImpl] get; }

    /// <summary>Gets the scale of the depth values in a DepthMediaFrame, in meters.</summary>
    /// <returns>The scale of the depth values in a DepthMediaFrame, in meters.</returns>
    public extern double DepthScaleInMeters { [MethodImpl] get; }
  }
}
