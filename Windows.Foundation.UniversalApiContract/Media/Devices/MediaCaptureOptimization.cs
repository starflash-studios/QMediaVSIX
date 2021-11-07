// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaCaptureOptimization
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the optimizations that the media capture device can use.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaCaptureOptimization
  {
    /// <summary>The default driver settings are used.</summary>
    Default,
    /// <summary>High picture quality is prioritized.</summary>
    Quality,
    /// <summary>Low latency is prioritized.</summary>
    Latency,
    /// <summary>Low power consumption is prioritized.</summary>
    Power,
    /// <summary>Low latency is prioritized, with high picture quality prioritized second.</summary>
    LatencyThenQuality,
    /// <summary>Low latency is prioritized, with low power consumption prioritized second.</summary>
    LatencyThenPower,
    /// <summary>Low power consumption and high picture quality are prioritized.</summary>
    PowerAndQuality,
  }
}
