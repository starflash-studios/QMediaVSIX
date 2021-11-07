// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandNetwork
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a mobile broadband network and the current network state.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class MobileBroadbandNetwork : 
    IMobileBroadbandNetwork,
    IMobileBroadbandNetwork2,
    IMobileBroadbandNetwork3
  {
    /// <summary>Gets the unique network interface that identifies the mobile broadband network.</summary>
    /// <returns>An object that uniquely identifies the network.</returns>
    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    /// <summary>Gets the current network registration state.</summary>
    /// <returns>The current network registration state.</returns>
    public extern NetworkRegistrationState NetworkRegistrationState { [MethodImpl] get; }

    /// <summary>Gets the latest network registration error.</summary>
    /// <returns>The latest network registration error.</returns>
    public extern uint RegistrationNetworkError { [MethodImpl] get; }

    /// <summary>Gets the latest packet attach network error.</summary>
    /// <returns>The latest packet attach network error.</returns>
    public extern uint PacketAttachNetworkError { [MethodImpl] get; }

    /// <summary>Attempts to get the latest network activation error.</summary>
    /// <returns>The latest network activation error.</returns>
    public extern uint ActivationNetworkError { [MethodImpl] get; }

    /// <summary>The name of the currently connected access point.</summary>
    /// <returns>The name of the currently connected access point.</returns>
    public extern string AccessPointName { [MethodImpl] get; }

    /// <summary>Gets the data class of the current mobile network.</summary>
    /// <returns>The data class of the current mobile network.</returns>
    public extern DataClasses RegisteredDataClass { [MethodImpl] get; }

    /// <summary>Gets the provider ID for the currently registered mobile network.</summary>
    /// <returns>The provider ID for the currently registered mobile network.</returns>
    public extern string RegisteredProviderId { [MethodImpl] get; }

    /// <summary>Gets the provider name for the currently registered mobile network.</summary>
    /// <returns>The provider name for the currently registered mobile network.</returns>
    public extern string RegisteredProviderName { [MethodImpl] get; }

    /// <summary>Displays the connect UI for a specific mobile network.</summary>
    [MethodImpl]
    public extern void ShowConnectionUI();

    /// <summary>Asynchronously retrieves a value indicating whether this network currently supports voice calls.</summary>
    /// <returns>An asynchronous retrieval operation. On successful completion, contains a value indicating whether the network supports voice calls (if true) or not.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetVoiceCallSupportAsync();

    /// <summary>Gets a list of all UICC apps available on the SIM card that can be used for registration on a mobile network. This list includes UICC apps that are not currently used for registration, but could potentially could be used for registration.</summary>
    /// <returns>A list of objects that represent UICC applications.</returns>
    public extern IVectorView<MobileBroadbandUiccApp> RegistrationUiccApps { [MethodImpl] get; }

    /// <summary>Retrieves a **MobileBroadbandCellsInfo** object that contains all serving and neighboring cell information when device is registered to a network.</summary>
    /// <returns>An asynchronous operation that returns a **MobileBroadbandCellsInfo** object upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandCellsInfo> GetCellsInfoAsync();
  }
}
