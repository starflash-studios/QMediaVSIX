// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>A request from an app that's in control of this IPerceptionFrameProvider to update a property.</summary>
  /// <deprecated type="deprecate">PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PerceptionPropertyChangeRequest : IPerceptionPropertyChangeRequest
  {
    /// <summary>Gets the name of the property to change.</summary>
    /// <returns>The name of the property to change.</returns>
    public extern string Name { [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the requested new value of the property.</summary>
    /// <returns>The requested new value of the property.</returns>
    public extern object Value { [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] [return: Variant] get; }

    /// <summary>Sets the new status of the request after processing the request.</summary>
    /// <returns>The currently stored status of the request.</returns>
    public extern PerceptionFrameSourcePropertyChangeStatus Status { [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets a Windows::Foundation::Deferral object to allow background processing if needed.</summary>
    /// <deprecated type="deprecate">PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <returns>The Deferral object.</returns>
    [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
