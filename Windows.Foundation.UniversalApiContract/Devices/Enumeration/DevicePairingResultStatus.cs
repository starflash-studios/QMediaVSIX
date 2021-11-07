// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePairingResultStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>The result of the pairing action with an Association Endpoint (AEP) device object. For more information about AEP objects, see DeviceInformationKind.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DevicePairingResultStatus
  {
    /// <summary>The device object is now paired.</summary>
    Paired,
    /// <summary>The device object is not in a state where it can be paired.</summary>
    NotReadyToPair,
    /// <summary>The device object is not currently paired.</summary>
    NotPaired,
    /// <summary>The device object has already been paired.</summary>
    AlreadyPaired,
    /// <summary>The device object rejected the connection.</summary>
    ConnectionRejected,
    /// <summary>The device object indicated it cannot accept any more incoming connections.</summary>
    TooManyConnections,
    /// <summary>The device object indicated there was a hardware failure.</summary>
    HardwareFailure,
    /// <summary>The authentication process timed out before it could complete.</summary>
    AuthenticationTimeout,
    /// <summary>The authentication protocol is not supported, so the device is not paired.</summary>
    AuthenticationNotAllowed,
    /// <summary>Authentication failed, so the device is not paired. Either the device object or the application rejected the authentication.</summary>
    AuthenticationFailure,
    /// <summary>There are no network profiles for this device object to use.</summary>
    NoSupportedProfiles,
    /// <summary>The minimum level of protection is not supported by the device object or the application.</summary>
    ProtectionLevelCouldNotBeMet,
    /// <summary>Your application does not have the appropriate permissions level to pair the device object.</summary>
    AccessDenied,
    /// <summary>The ceremony data was incorrect.</summary>
    InvalidCeremonyData,
    /// <summary>The pairing action was canceled before completion.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] PairingCanceled,
    /// <summary>The device object is already attempting to pair or unpair.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] OperationAlreadyInProgress,
    /// <summary>Either the event handler wasn't registered or a required DevicePairingKinds was not supported.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] RequiredHandlerNotRegistered,
    /// <summary>The application handler rejected the pairing.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] RejectedByHandler,
    /// <summary>The remove device already has an association.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] RemoteDeviceHasAssociation,
    /// <summary>An unknown failure occurred.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] Failed,
  }
}
