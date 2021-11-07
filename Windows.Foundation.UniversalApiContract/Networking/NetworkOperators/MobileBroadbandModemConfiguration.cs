// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandModemConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains details about the mobile broadband modem configuration.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandModemConfiguration : 
    IMobileBroadbandModemConfiguration,
    IMobileBroadbandModemConfiguration2
  {
    /// <summary>Gets an object representing the Universal Integrated Circuit Card (UICC), commonly called a "SIM card", associated with the mobile broadband modem.</summary>
    /// <returns>Represents the UICC.</returns>
    public extern MobileBroadbandUicc Uicc { [MethodImpl] get; }

    /// <summary>Gets the home provider ID associated with the mobile broadband modem.</summary>
    /// <returns>The home provider ID.</returns>
    public extern string HomeProviderId { [MethodImpl] get; }

    /// <summary>Gets the home provider name for the mobile broadband modem.</summary>
    /// <returns>The home provider name.</returns>
    public extern string HomeProviderName { [MethodImpl] get; }

    /// <summary>Gets the MobileBroadbandSarManager object that manages SAR and antenna relevant operations.</summary>
    /// <returns>The MobileBroadbandSarManager object that manages SAR and antenna relevant operations.</returns>
    public extern MobileBroadbandSarManager SarManager { [MethodImpl] get; }
  }
}
