// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPinType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the possible types for a mobile broadband PIN.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MobileBroadbandPinType
  {
    /// <summary>Not used (only for initialization).</summary>
    None,
    /// <summary>This is a custom vendor-defined PIN type. It is not included in the list.</summary>
    Custom,
    /// <summary>For GSM-based devices, this is a Subscriber Identity Module (SIM) PIN. For CDMA-based devices, power-on device lock is reported as PIN1.</summary>
    Pin1,
    /// <summary>This is a SIM PIN2 that protects certain SIM functionality.</summary>
    Pin2,
    /// <summary>This is a PIN that locks the device to a specific SIM card.</summary>
    SimPin,
    /// <summary>This is a PIN that locks the device to the very first inserted SIM card.</summary>
    FirstSimPin,
    /// <summary>This is a PIN that allows the device to be personalized to a network. For more information about this PIN type, see section 22.022 of the 3GPP specification.</summary>
    NetworkPin,
    /// <summary>This is a PIN that allows the device to be personalized to a subset of a network. For more information about this PIN type, see section 22.022 of the 3GPP specification.</summary>
    NetworkSubsetPin,
    /// <summary>This is a PIN that allows the device to be personalized to a service provider. For more information about this PIN type, see section 22.022 of the 3GPP specification.</summary>
    ServiceProviderPin,
    /// <summary>This is a PIN that allows the device to be personalized to a specific company. For more information about this PIN type, see section 22.022 of the 3GPP specification.</summary>
    CorporatePin,
    /// <summary>This is a PIN that allows the device to be restricted to operate on a specific network. For more information about this PIN type, see section 22.022 of the 3GPP specification.</summary>
    SubsidyLock,
  }
}
