// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorEventMessageType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the type of a network operator notification message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NetworkOperatorEventMessageType
  {
    /// <summary>The message type is GSM.</summary>
    Gsm,
    /// <summary>The message type is CDMA.</summary>
    Cdma,
    /// <summary>The message type is USSD.</summary>
    Ussd,
    /// <summary>Data plan data threshold has been reached.</summary>
    DataPlanThresholdReached,
    /// <summary>Data plan has been reset.</summary>
    DataPlanReset,
    /// <summary>Data plan has been deleted.</summary>
    DataPlanDeleted,
    /// <summary>Profile connected to mobile operator.</summary>
    ProfileConnected,
    /// <summary>Profile disconnected from mobile operator.</summary>
    ProfileDisconnected,
    /// <summary>Mobile broadband device registered as roaming.</summary>
    RegisteredRoaming,
    /// <summary>Mobile broadband device registered as home.</summary>
    RegisteredHome,
    /// <summary>Mobile broadband device can be used for tethering.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TetheringEntitlementCheck,
    /// <summary>Operational state of the device's tethering capability has changed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TetheringOperationalStateChanged,
    /// <summary>Number of clients currently using the tethering network has changed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TetheringNumberOfClientsChanged,
  }
}
