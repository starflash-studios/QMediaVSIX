// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionFaceAuthenticationGroupFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Deprecated("PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(3867805140, 46604, 16628, 188, 185, 242, 77, 70, 70, 115, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PerceptionFaceAuthenticationGroup))]
  internal interface IPerceptionFaceAuthenticationGroupFactory
  {
    [Deprecated("PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionFaceAuthenticationGroup Create(
      IIterable<string> ids,
      PerceptionStartFaceAuthenticationHandler startHandler,
      PerceptionStopFaceAuthenticationHandler stopHandler);
  }
}
