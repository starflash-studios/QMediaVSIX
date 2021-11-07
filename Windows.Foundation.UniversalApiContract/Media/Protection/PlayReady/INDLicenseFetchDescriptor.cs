// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Retrieves and sets properties used for fetching a PlayReady-ND license.</summary>
  /// <deprecated type="deprecate">INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1419301690, 59014, 18741, 165, 103, 124, 167, 122, 210, 15, 164)]
  public interface INDLicenseFetchDescriptor
  {
    /// <summary>Gets the type of the content identifier used for fetching a license.</summary>
    /// <returns>The content identifier type. The value can be either **KeyID**, **PlayReadyObject**, or **Custom**.</returns>
    NDContentIDType ContentIDType { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the content identifier used for fetching a license.</summary>
    /// <returns>The content identifier.</returns>
    byte[] ContentID { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets or sets custom data for a license fetch challenge.</summary>
    /// <returns>The custom data from or for the license challenge.</returns>
    INDCustomData LicenseFetchChallengeCustomData { [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("INDLicenseFetchDescriptor is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
