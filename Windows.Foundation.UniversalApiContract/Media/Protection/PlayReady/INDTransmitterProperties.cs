// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDTransmitterProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides the property values for a PlayReady-ND transmitter certificate.</summary>
  /// <deprecated type="deprecate">INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(3845566243, 44111, 19164, 140, 102, 79, 247, 194, 112, 45, 214)]
  public interface INDTransmitterProperties
  {
    /// <summary>Gets the certificate type for the transmitter.</summary>
    /// <returns>The certificate type. This value can be either **DRM_BCERT_CERTTYPE_PC** (0x1) or **DRM_BCERT_CERTTYPE_DEVICE** (0x2).</returns>
    NDCertificateType CertificateType { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the platform identifier from a transmitter certificate.</summary>
    /// <returns>The platform identifier.</returns>
    NDCertificatePlatformID PlatformIdentifier { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the list of supported features from the transmitter certificate.</summary>
    /// <returns>An array identifying the feature sets that the certificate supports.</returns>
    NDCertificateFeature[] SupportedFeatures { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the security level from a transmitter certificate.</summary>
    /// <returns>The security level.</returns>
    uint SecurityLevel { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the security version from a transmitter certificate.</summary>
    /// <returns>The security version.</returns>
    uint SecurityVersion { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the expiration date and time from the transmitter certificate.</summary>
    /// <returns>The date and time the certificate expires.</returns>
    DateTime ExpirationDate { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the client identifier from the transmitter certificate.</summary>
    /// <returns>The client identifier.</returns>
    byte[] ClientID { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the model digest from a transmitter certificate.</summary>
    /// <returns>The model digest.</returns>
    byte[] ModelDigest { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the model manufacturer name from a transmitter certificate.</summary>
    /// <returns>The model manufacturer name.</returns>
    string ModelManufacturerName { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the model name from a transmitter certificate.</summary>
    /// <returns>The model name.</returns>
    string ModelName { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the model number from a transmitter certificate.</summary>
    /// <returns>The model number as a text string.</returns>
    string ModelNumber { [Deprecated("INDTransmitterProperties is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
