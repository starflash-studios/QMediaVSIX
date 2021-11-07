// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionControlGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [ExclusiveTo(typeof (PerceptionControlGroup))]
  [Guid(388778114, 12249, 19534, 186, 52, 253, 242, 10, 115, 221, 229)]
  [Deprecated("PerceptionControlGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionControlGroup
  {
    IVectorView<string> FrameProviderIds { [Deprecated("PerceptionControlGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
