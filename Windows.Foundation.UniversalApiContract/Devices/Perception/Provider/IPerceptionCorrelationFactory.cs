// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionCorrelationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Perception.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionCorrelation))]
  [Guid(3567698981, 10372, 19087, 129, 52, 40, 53, 215, 40, 108, 191)]
  internal interface IPerceptionCorrelationFactory
  {
    [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionCorrelation Create(
      string targetId,
      Vector3 position,
      Quaternion orientation);
  }
}
