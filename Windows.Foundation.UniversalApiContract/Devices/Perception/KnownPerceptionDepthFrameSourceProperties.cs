// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.KnownPerceptionDepthFrameSourceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides static properties of depth frame sources.</summary>
  /// <deprecated type="deprecate">KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [Static(typeof (IKnownPerceptionDepthFrameSourcePropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class KnownPerceptionDepthFrameSourceProperties
  {
    /// <summary>Gets a string key used to retrieve a 16-bit unsigned integer property indicating the minimum depth of the depth frame source.</summary>
    /// <returns>Indicates the minimum depth of the depth frame source. This property is a UInt16 value.</returns>
    public static extern string MinDepth { [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a 16-bit unsigned integer property indicating the maximum depth of the depth frame source.</summary>
    /// <returns>Indicates the maximum depth of the depth frame source. This property is a UInt16 value.</returns>
    public static extern string MaxDepth { [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
