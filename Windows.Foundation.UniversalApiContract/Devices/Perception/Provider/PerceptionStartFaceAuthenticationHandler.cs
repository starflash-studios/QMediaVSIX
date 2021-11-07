// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionStartFaceAuthenticationHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>Invoked when a PerceptionFaceAuthenticationGroup enters Face Authentication mode.</summary>
  /// <deprecated type="deprecate">PerceptionStartFaceAuthenticationHandler may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  /// <returns>True if the group is ready to preform Face Authentication; otherwise, false.</returns>
  /// <param name="sender">The associated PerceptionFaceAuthenticationGroup that was registered.</param>
  [Deprecated("PerceptionStartFaceAuthenticationHandler may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(1954639146, 8336, 18032, 140, 72, 239, 57, 231, 255, 124, 38)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate bool PerceptionStartFaceAuthenticationHandler(
    PerceptionFaceAuthenticationGroup sender);
}
