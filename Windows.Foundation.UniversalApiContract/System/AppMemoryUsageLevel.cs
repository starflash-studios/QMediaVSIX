// Decompiled with JetBrains decompiler
// Type: Windows.System.AppMemoryUsageLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>An enumeration containing 4 levels of app memory usage: low, medium, high, and overlimit.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppMemoryUsageLevel
  {
    /// <summary>Low app memory usage.</summary>
    Low,
    /// <summary>Medium app memory usage.</summary>
    Medium,
    /// <summary>High app memory usage.</summary>
    High,
    /// <summary>App memory usage is over the limit.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] OverLimit,
  }
}
