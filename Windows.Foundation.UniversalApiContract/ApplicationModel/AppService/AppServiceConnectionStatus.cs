// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceConnectionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Describes the status for the attempt that an app makes to open a connection to an app service by calling the AppServiceConnection.OpenAsync method. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppServiceConnectionStatus
  {
    /// <summary>The connection to the app service was opened successfully.</summary>
    Success,
    /// <summary>The package for the app service to which a connection was attempted is not installed on the device. Check that the package is installed before trying to open a connection to the app service.</summary>
    AppNotInstalled,
    /// <summary>The package for the app service to which a connection was attempted is temporarily unavailable. Try to connect again later.</summary>
    AppUnavailable,
    /// <summary>The app with the specified package family name is installed and available, but the app does not declare support for the specified app service. Check that the name of the app service and the version of the app are correct.</summary>
    AppServiceUnavailable,
    /// <summary>An unknown error occurred.</summary>
    Unknown,
    /// <summary>The device to which a connection was attempted is not available.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] RemoteSystemUnavailable,
    /// <summary>The app on the remote device does not support remote connections. It needs to specify SupportsRemoteSystems="true" on the appService extension in its AppXManifest to accept remote connections.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] RemoteSystemNotSupportedByApp,
    /// <summary>The user for your app is not authorized to connect to the service.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] NotAuthorized,
    /// <summary>The operation failed due to unsuccessful account authentication. The user must re-validate the account to continue.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] AuthenticationError,
    /// <summary>The operation failed due to lack of an internet connection.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] NetworkNotAvailable,
    /// <summary>The operation failed, as the app service needed service or capabilities disabled by some policies on the local or remote device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] DisabledByPolicy,
    /// <summary>The operation failed because one or more necessary cloud services were temporarily unavailable.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] WebServiceUnavailable,
  }
}
