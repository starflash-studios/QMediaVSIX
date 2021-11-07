// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.CortanaPermissionsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  /// <summary>Provides access to the users Cortana authorization settings.</summary>
  /// <deprecated type="deprecate">CortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Static(typeof (ICortanaPermissionsManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("CortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class CortanaPermissionsManager : ICortanaPermissionsManager
  {
    /// <summary>Retrieves whether Cortana is supported.</summary>
    /// <deprecated type="deprecate">ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <returns>**true** if Cortana is supported. Otherwise, **false**.</returns>
    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern bool IsSupported();

    [RemoteAsync]
    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<bool> ArePermissionsGrantedAsync(
      IIterable<CortanaPermission> permissions);

    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CortanaPermissionsChangeResult> GrantPermissionsAsync(
      IIterable<CortanaPermission> permissions);

    [RemoteAsync]
    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<CortanaPermissionsChangeResult> RevokePermissionsAsync(
      IIterable<CortanaPermission> permissions);

    /// <summary>Retrieves the Cortana permissions for the current user.</summary>
    /// <deprecated type="deprecate">ICortanaPermissionsManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <returns>
    /// </returns>
    [Deprecated("ICortanaPermissionsManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern CortanaPermissionsManager GetDefault();
  }
}
