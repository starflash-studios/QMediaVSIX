// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDLicenseFetchDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Retrieves and sets properties used for fetching a PlayReady-ND license.</summary>
  /// <deprecated type="deprecate">NDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Activatable(typeof (INDLicenseFetchDescriptorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("NDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NDLicenseFetchDescriptor : INDLicenseFetchDescriptor
  {
    /// <summary>Creates a new instance of the NDLicenseFetchDescriptor class.</summary>
    /// <deprecated type="deprecate">INDLicenseFetchDescriptorFactory is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="contentIDType">The type of the content identifier.</param>
    /// <param name="contentIDBytes">The content identifier.</param>
    /// <param name="licenseFetchChallengeCustomData">The license fetch challenge custom data.</param>
    [Deprecated("INDLicenseFetchDescriptorFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDLicenseFetchDescriptor(
      NDContentIDType contentIDType,
      byte[] contentIDBytes,
      INDCustomData licenseFetchChallengeCustomData);

    /// <summary>Gets the type of the content identifier.</summary>
    /// <returns>The content identifier type. This value can be **KeyID**, **PlayReadyObject**, or **Custom**.</returns>
    public extern NDContentIDType ContentIDType { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the content identifer.</summary>
    /// <returns>The content identifier.</returns>
    public extern byte[] ContentID { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets custom data for a license fetch challenge.</summary>
    /// <returns>The custom data from or for the license challenge.</returns>
    public extern INDCustomData LicenseFetchChallengeCustomData { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
