// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ProvisioningAgent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents an agent that provisions connectivity and subscription information with a network provider.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IProvisioningAgentStaticMethods), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProvisioningAgent : IProvisioningAgent
  {
    /// <summary>Creates a new instance of a ProvisioningAgent.</summary>
    [MethodImpl]
    public extern ProvisioningAgent();

    /// <summary>Provisions a device for network connectivity asynchronously, based on the supplied XML document.</summary>
    /// <param name="provisioningXmlDocument">An instance of CarrierControlSchema that contains the network connectivity provisioning information.</param>
    /// <returns>An asynchronous handler to start the provisioning attempt and track its completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync(
      string provisioningXmlDocument);

    /// <summary>Retrieves cost and plan information associated with the mobile broadband profile.</summary>
    /// <param name="mediaType">The media type that the profile belongs to.</param>
    /// <param name="profileName">The name of the profile that the cost will be applied to.</param>
    /// <returns>The profile.</returns>
    [MethodImpl]
    public extern ProvisionedProfile GetProvisionedProfile(
      ProfileMediaType mediaType,
      string profileName);

    /// <summary>Creates a provisioning agent for the mobile device associated with the supplied network account ID.</summary>
    /// <param name="networkAccountId">The network account ID to use to select the corresponding mobile broadband device to use for the provisioning agent.</param>
    /// <returns>The provisioning agent for the mobile device associated with the supplied network account ID.</returns>
    [MethodImpl]
    public static extern ProvisioningAgent CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
