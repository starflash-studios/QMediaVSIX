// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionFaceAuthenticationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionFaceAuthenticationGroup))]
  [Guid(3892418580, 19089, 16816, 131, 166, 136, 26, 23, 117, 53, 62)]
  internal interface IPerceptionFaceAuthenticationGroup
  {
    IVectorView<string> FrameProviderIds { [Deprecated("PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
