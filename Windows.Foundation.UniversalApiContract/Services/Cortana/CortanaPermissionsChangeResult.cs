// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.CortanaPermissionsChangeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  /// <summary>Specifies the possible results from setting permissions using the CortanaPermissionsManager.</summary>
  /// <deprecated type="deprecate">CortanaPermissionsChangeResult is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("CortanaPermissionsChangeResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum CortanaPermissionsChangeResult
  {
    /// <summary>Setting all permissions succeeded.</summary>
    Success,
    /// <summary>Setting one or more permissions failed.</summary>
    Unavailable,
    /// <summary>Changes to settings are not permitted.</summary>
    DisabledByPolicy,
  }
}
