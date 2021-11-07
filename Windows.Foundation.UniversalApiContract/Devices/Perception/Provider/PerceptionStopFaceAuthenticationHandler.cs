// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionStopFaceAuthenticationHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>Invoked when a PerceptionFaceAuthenticationGroup exits Face Authentication mode. This will only be invoked after the group received a PerceptionStartFaceAuthenticationHandler from which it returned true.</summary>
  /// <deprecated type="deprecate">PerceptionStopFaceAuthenticationHandler may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  /// <param name="sender">The associated PerceptionFaceAuthenticationGroup that was registered.</param>
  [Deprecated("PerceptionStopFaceAuthenticationHandler may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(947840682, 35277, 18462, 170, 222, 221, 146, 247, 11, 42, 215)]
  public delegate void PerceptionStopFaceAuthenticationHandler(
    PerceptionFaceAuthenticationGroup sender);
}
