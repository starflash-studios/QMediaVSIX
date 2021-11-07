// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.StatelessAppServiceResponseStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Indicates success or failure of a SendStatelessMessageAsync operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum StatelessAppServiceResponseStatus
  {
    /// <summary>The operation completed succesfully.</summary>
    Success,
    /// <summary>The operation failed due to the app not being presented on the remote system.</summary>
    AppNotInstalled,
    /// <summary>The operation failed due to the app failing to start.</summary>
    AppUnavailable,
    /// <summary>The operation failed due to the app not supporting the requested app service.</summary>
    AppServiceUnavailable,
    /// <summary>The operation failed due to the remote system being unavailable.</summary>
    RemoteSystemUnavailable,
    /// <summary>The operation failed due to the app service on the remote system missing the SupportsRemoteSystems flag.</summary>
    RemoteSystemNotSupportedByApp,
    /// <summary>The operation failed due to authorization.</summary>
    NotAuthorized,
    /// <summary>The operation failed due to resource limits being exceeded.</summary>
    ResourceLimitsExceeded,
    /// <summary>The operation failed due to the message size being too large.</summary>
    MessageSizeTooLarge,
    /// <summary>The operation failed.</summary>
    Failure,
    /// <summary>An unknown error occurred.</summary>
    Unknown,
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
