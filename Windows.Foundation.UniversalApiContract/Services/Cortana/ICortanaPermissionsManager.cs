// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.ICortanaPermissionsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  [ExclusiveTo(typeof (CortanaPermissionsManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(420688096, 34453, 17290, 149, 69, 61, 164, 232, 34, 221, 180)]
  [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  internal interface ICortanaPermissionsManager
  {
    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    bool IsSupported();

    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<bool> ArePermissionsGrantedAsync(
      IIterable<CortanaPermission> permissions);

    [RemoteAsync]
    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<CortanaPermissionsChangeResult> GrantPermissionsAsync(
      IIterable<CortanaPermission> permissions);

    [Deprecated("ICortanaPermissionsManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<CortanaPermissionsChangeResult> RevokePermissionsAsync(
      IIterable<CortanaPermission> permissions);
  }
}
