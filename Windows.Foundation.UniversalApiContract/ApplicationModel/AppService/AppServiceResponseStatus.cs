// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceResponseStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Describes the status when an app tries to send a message to an app service by calling the AppServiceConnection.SendMessageAsync method. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppServiceResponseStatus
  {
    /// <summary>The app service successfully received and processed the message.</summary>
    Success,
    /// <summary>The app service failed to receive and process the message.</summary>
    Failure,
    /// <summary>The app service exited because not enough resources were available.</summary>
    ResourceLimitsExceeded,
    /// <summary>An unknown error occurred.</summary>
    Unknown,
    /// <summary>The device to which the message was sent is not available.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] RemoteSystemUnavailable,
    /// <summary>The app service failed to process the message because it is too large.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] MessageSizeTooLarge,
    /// <summary>The operation failed due to the app failing to start.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] AppUnavailable,
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
