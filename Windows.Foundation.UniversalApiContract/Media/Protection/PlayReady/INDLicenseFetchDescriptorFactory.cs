// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(3489862146, 53164, 20224, 174, 106, 151, 175, 128, 184, 72, 242)]
  [Deprecated("INDLicenseFetchDescriptorFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (NDLicenseFetchDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INDLicenseFetchDescriptorFactory
  {
    [Deprecated("INDLicenseFetchDescriptorFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    NDLicenseFetchDescriptor CreateInstance(
      NDContentIDType contentIDType,
      byte[] contentIDBytes,
      INDCustomData licenseFetchChallengeCustomData);
  }
}
