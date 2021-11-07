// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionFrameProviderManagerServiceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Guid(2927855334, 51929, 17241, 143, 150, 142, 174, 81, 129, 5, 38)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PerceptionFrameProviderManagerService))]
  [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionFrameProviderManagerServiceStatics
  {
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void RegisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnregisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UpdateAvailabilityForProvider(IPerceptionFrameProvider provider, bool available);

    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void PublishFrameForProvider(IPerceptionFrameProvider provider, PerceptionFrame frame);
  }
}
