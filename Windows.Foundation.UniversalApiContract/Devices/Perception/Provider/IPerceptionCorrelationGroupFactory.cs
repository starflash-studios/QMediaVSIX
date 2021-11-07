// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionCorrelationGroupFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Deprecated("PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(2113806472, 25567, 18669, 131, 177, 74, 184, 41, 19, 41, 149)]
  [ExclusiveTo(typeof (PerceptionCorrelationGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionCorrelationGroupFactory
  {
    [Deprecated("PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionCorrelationGroup Create(
      IIterable<PerceptionCorrelation> relativeLocations);
  }
}
