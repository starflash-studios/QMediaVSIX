// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorServiceResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  /// <summary>This API is for internal use only and should not be used in your code.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MicrosoftAccountMultiFactorServiceResponse
  {
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    Success,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    Error,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    NoNetworkConnection,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    ServiceUnavailable,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    TotpSetupDenied,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    NgcNotSetup,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    SessionAlreadyDenied,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    SessionAlreadyApproved,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    SessionExpired,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    NgcNonceExpired,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    InvalidSessionId,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    InvalidSessionType,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    InvalidOperation,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    InvalidStateTransition,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    DeviceNotFound,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    FlowDisabled,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    SessionNotApproved,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    OperationCanceledByUser,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    NgcDisabledByServer,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    NgcKeyNotFoundOnServer,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    UIRequired,
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    DeviceIdChanged,
  }
}
