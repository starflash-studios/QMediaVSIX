// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a mobile broadband account and related information about the network provider for the account.</summary>
  [Static(typeof (IMobileBroadbandAccountStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class MobileBroadbandAccount : 
    IMobileBroadbandAccount,
    IMobileBroadbandAccount2,
    IMobileBroadbandAccount3
  {
    /// <summary>Gets a unique identifier for the mobile broadband account.</summary>
    /// <returns>A unique identifier for the mobile broadband account.</returns>
    public extern string NetworkAccountId { [MethodImpl] get; }

    /// <summary>A unique identifier for the network provider for the mobile broadband account.</summary>
    /// <returns>A unique identifier for the network provider for the mobile broadband account.</returns>
    public extern Guid ServiceProviderGuid { [MethodImpl] get; }

    /// <summary>The name of the network provider for the mobile broadband account.</summary>
    /// <returns>The name of the network provider for the mobile broadband account.</returns>
    public extern string ServiceProviderName { [MethodImpl] get; }

    /// <summary>Gets the Mobile Broadband network object for this account.</summary>
    /// <returns>The Mobile Broadband network object for this account.</returns>
    public extern MobileBroadbandNetwork CurrentNetwork { [MethodImpl] get; }

    /// <summary>Gets the mobile broadband device information associated with this account.</summary>
    /// <returns>The mobile broadband device information associated with this account.</returns>
    public extern MobileBroadbandDeviceInformation CurrentDeviceInformation { [MethodImpl] get; }

    /// <summary>Retrieves an array of ConnectionProfile objects that represent connections associated with the Mobile Broadband account.</summary>
    /// <returns>An array of ConnectionProfile objects.</returns>
    [MethodImpl]
    public extern IVectorView<ConnectionProfile> GetConnectionProfiles();

    /// <summary>Returns the Account Experience URL associated with the Mobile Broadband account.</summary>
    /// <returns>The URL of the operator’s website used to configure Mobile Broadband.</returns>
    public extern global::Windows.Foundation.Uri AccountExperienceUrl { [MethodImpl] get; }

    /// <summary>A list of all network account IDs for the network service provider.</summary>
    /// <returns>A list of all network account IDs for the network service provider.</returns>
    public static extern IVectorView<string> AvailableNetworkAccountIds { [MethodImpl] get; }

    /// <summary>Creates a mobile broadband account for the mobile device associated with the supplied network account ID.</summary>
    /// <param name="networkAccountId">The network account ID to use to select the corresponding mobile broadband device to use for the account.</param>
    /// <returns>A mobile broadband account for the mobile device associated with the supplied network account ID.</returns>
    [MethodImpl]
    public static extern MobileBroadbandAccount CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
