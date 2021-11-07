// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Provides information about the SecondaryAuthenticationFactorAuthenticationStageChanged event.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs : 
    ISecondaryAuthenticationFactorAuthenticationStageChangedEventArgs
  {
    /// <summary>Gets info on the authentication stage.</summary>
    /// <returns>Info on the authentication stage.</returns>
    public extern SecondaryAuthenticationFactorAuthenticationStageInfo StageInfo { [Deprecated("SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
