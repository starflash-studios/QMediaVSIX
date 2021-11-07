// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SecondaryAuthenticationFactorAuthenticationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task on behalf of a companion device.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthenticationTrigger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationTrigger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class SecondaryAuthenticationFactorAuthenticationTrigger : 
    ISecondaryAuthenticationFactorAuthenticationTrigger,
    IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of the SecondaryAuthenticationFactorAuthenticationTrigger class.</summary>
    [MethodImpl]
    public extern SecondaryAuthenticationFactorAuthenticationTrigger();
  }
}
