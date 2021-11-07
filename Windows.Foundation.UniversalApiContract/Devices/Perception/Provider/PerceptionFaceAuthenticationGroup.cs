// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionFaceAuthenticationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>A group of unique identifiers specifying IPerceptionFrameProviders that share handlers for entering and exiting Face Authentication mode.</summary>
  /// <deprecated type="deprecate">PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IPerceptionFaceAuthenticationGroupFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionFaceAuthenticationGroup : IPerceptionFaceAuthenticationGroup
  {
    [Deprecated("PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionFaceAuthenticationGroup(
      IIterable<string> ids,
      PerceptionStartFaceAuthenticationHandler startHandler,
      PerceptionStopFaceAuthenticationHandler stopHandler);

    /// <summary>The id(s) of the IPerceptionFrameProvider(s) referenced by this group.</summary>
    /// <returns>The id(s) of the IPerceptionFrameProvider(s) referenced by this group.</returns>
    public extern IVectorView<string> FrameProviderIds { [Deprecated("PerceptionFaceAuthenticationGroup may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
