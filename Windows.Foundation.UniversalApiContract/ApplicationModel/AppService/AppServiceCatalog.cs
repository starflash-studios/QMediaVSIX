// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceCatalog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Enumerate the available app service providers on the device. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAppServiceCatalogStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class AppServiceCatalog
  {
    /// <summary>Returns the list of app service providers that match a specific app service name on the device.</summary>
    /// <param name="appServiceName">The name of the app service to find.</param>
    /// <returns>A list of AppInfo s for the app service provider(s) that are available for the specified app service name.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindAppServiceProvidersAsync(
      string appServiceName);
  }
}
