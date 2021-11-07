// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>The IPerceptionFrameProviderManager is expected to provide any IPerceptionFrameProvider that has been registered via PerceptionFrameProviderManagerService::RegisterFrameProviderInfo().</summary>
  /// <deprecated type="deprecate">IPerceptionFrameProviderManager may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2841234951, 60115, 13279, 142, 193, 185, 36, 171, 224, 25, 196)]
  [Deprecated("IPerceptionFrameProviderManager may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public interface IPerceptionFrameProviderManager : IClosable
  {
    /// <summary>The method to request an IPerceptionFrameProvider associated with a registered PerceptionFrameProviderInfo.</summary>
    /// <deprecated type="deprecate">IPerceptionFrameProviderManager may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="frameProviderInfo">The info specifying the desired IPerceptionFrameProvider.</param>
    /// <returns>The associated IPerceptionFrameProvider, or nullptr if there is no such registerd provider.</returns>
    [Deprecated("IPerceptionFrameProviderManager may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IPerceptionFrameProvider GetFrameProvider(
      PerceptionFrameProviderInfo frameProviderInfo);
  }
}
