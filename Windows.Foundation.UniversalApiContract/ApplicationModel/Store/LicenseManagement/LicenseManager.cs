// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.LicenseManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  /// <summary>Provides members for managing license info for apps.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (ILicenseManagerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ILicenseManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class LicenseManager
  {
    /// <summary>Refreshes license info for app licenses on the current device.</summary>
    /// <param name="refreshOption">A LicenseRefreshOption that indicates whether to refresh all app licenses on the device or only the licenses for currently running apps.</param>
    /// <returns>An object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction RefreshLicensesAsync(
      LicenseRefreshOption refreshOption);

    /// <summary>Installs the specified app license.</summary>
    /// <param name="license">The contents of the license to install.</param>
    /// <returns>An object that represents the installation operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction AddLicenseAsync(IBuffer license);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LicenseSatisfactionResult> GetSatisfactionInfosAsync(
      IIterable<string> contentIds,
      IIterable<string> keyIds);
  }
}
