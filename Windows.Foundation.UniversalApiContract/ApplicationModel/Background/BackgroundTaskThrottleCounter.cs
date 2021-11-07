// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskThrottleCounter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Indicates the type of throttle count to check for in a GetThrottleCount request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundTaskThrottleCounter
  {
    /// <summary>Indicates a request for all throttle counts (CPU and network).</summary>
    All,
    /// <summary>Indicates a request for CPU throttle count.</summary>
    Cpu,
    /// <summary>Indicates a request for network throttle count.</summary>
    Network,
  }
}
