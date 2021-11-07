// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ProtectionCapabilityResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Specifies the result of a query for hardware DRM capability support using IsTypeSupported.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum ProtectionCapabilityResult
  {
    /// <summary>The queried features are not supported.</summary>
    NotSupported,
    /// <summary>Only relevant to output protection (HDCP) subsystem queries. ProtectionCapabilities.IsTypeSupported is a synchronous, blocking call which is constrained to only block for very short periods (goal is &lt; 100 milliseconds). As underlying HDCP establishment may take significantly longer than the blocking period, this **Maybe** result is returned while establishment is in progress.</summary>
    Maybe,
    /// <summary>The queried features are supported as of the time of the query.  Display configurations can change dynamically, so Display subsystem and HDCP subsystem query results may become invalid after the query.</summary>
    Probably,
  }
}
