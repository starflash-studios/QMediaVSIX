// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionCorrelationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>A collection of PerceptionCorrelations describing multiple unique providers in a common coordinate frame.</summary>
  /// <deprecated type="deprecate">PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [Activatable(typeof (IPerceptionCorrelationGroupFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionCorrelationGroup : IPerceptionCorrelationGroup
  {
    [Deprecated("PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionCorrelationGroup(IIterable<PerceptionCorrelation> relativeLocations);

    /// <summary>The collection of PerceptionCorrelations describing multiple unique providers in a common coordinate frame.</summary>
    /// <returns>The collection of PerceptionCorrelations describing multiple unique providers in a common coordinate frame.</returns>
    public extern IVectorView<PerceptionCorrelation> RelativeLocations { [Deprecated("PerceptionCorrelationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
