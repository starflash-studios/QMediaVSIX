// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimOperationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify the status of an ESimOperationResult object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ESimOperationStatus
  {
    /// <summary>Indicates that the operation was successful.</summary>
    Success,
    /// <summary>Indicates that the operation was not authorized.</summary>
    NotAuthorized,
    /// <summary>Indicates that the specified eSIM profile was not found.</summary>
    NotFound,
    /// <summary>Indicates that the operation violates policy.</summary>
    PolicyViolation,
    /// <summary>Indicates that there is not enough storage space on the card to complete the operation.</summary>
    InsufficientSpaceOnCard,
    /// <summary>Indicates that a server failure occurred during the operation.</summary>
    ServerFailure,
    /// <summary>Indicates that the server could not be reached during the operation.</summary>
    ServerNotReachable,
    /// <summary>Indicates that user consent was not granted within the timeout period of the operation.</summary>
    TimeoutWaitingForUserConsent,
    /// <summary>Indicates that the wrong confirmation code was supplied during the operation.</summary>
    IncorrectConfirmationCode,
    /// <summary>Indicates that the wrong confirmation code was supplied during the operation, and that no more retries are permitted.</summary>
    ConfirmationCodeMaxRetriesExceeded,
    /// <summary>Indicates that the SIM card has been removed.</summary>
    CardRemoved,
    /// <summary>Indicates that the SIM card is busy.</summary>
    CardBusy,
    /// <summary>Indicates a status that's not accounted for by a more specific status.</summary>
    Other,
    /// <summary>Indicates that a card error occurred that prevented the download/install/other operation from completing successfully.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] CardGeneralFailure,
    /// <summary>Indicates that a confirmation code is needed in order to download the eSIM profile.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] ConfirmationCodeMissing,
    /// <summary>Indicates that the matching ID from the activation code or discovered event was refused.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] InvalidMatchingId,
    /// <summary>Indicates that an eSIM profile compatible with this device could not be found. For example, a profile was found that requires LTE support, but the device only supports 3G.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] NoEligibleProfileForThisDevice,
    /// <summary>Indicates that the operation aborted.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] OperationAborted,
    /// <summary>Indicates that an eSIM profile on the mobile operator (MO) server is already allocated for a different eSIM EID than the one the device has.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] EidMismatch,
    /// <summary>Indicates that the user is trying to download an eSIM profile that has already been claimed/downloaded.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] ProfileNotAvailableForNewBinding,
    /// <summary>Indicates that the eSIM profile is available, but it is not yet marked as released for download by the mobile operator (MO). You can only download a released profile, so the MO needs to mark the profile as released.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] ProfileNotReleasedByOperator,
    /// <summary>Indicates that the operation is not allowed for the eSIM profile class.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] OperationProhibitedByProfileClass,
    /// <summary>Indicates that an eSIM profile could not be found.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] ProfileNotPresent,
    /// <summary>Indicates that no corresponding request could be found.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] NoCorrespondingRequest,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] TimeoutWaitingForResponse,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] IccidAlreadyExists,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] ProfileProcessingError,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] ServerNotTrusted,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] ProfileDownloadMaxRetriesExceeded,
  }
}
