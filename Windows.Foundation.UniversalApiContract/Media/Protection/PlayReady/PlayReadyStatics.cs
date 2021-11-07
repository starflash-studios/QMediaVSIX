// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides support for returning static or constant data.</summary>
  [Static(typeof (IPlayReadyStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayReadyStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPlayReadyStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayReadyStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayReadyStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  public static class PlayReadyStatics
  {
    /// <summary>Queries the date and time at which hardware digital rights management (DRM) was temporarily disabled on the system.</summary>
    /// <returns>The date and time at which hardware digital rights management (DRM) was temporarily disabled.  If it is not currently temporarily disabled, returns null.</returns>
    public static extern IReference<global::Windows.Foundation.DateTime> HardwareDRMDisabledAtTime { [MethodImpl] get; }

    /// <summary>Queries the date and time at which hardware digital rights management (DRM) will be re-enabled after it was temporarily disabled on the system.</summary>
    /// <returns>The date and time at which hardware digital rights management (DRM) will be re-enabled.  If it is not currently temporarily disabled, returns null.</returns>
    public static extern IReference<global::Windows.Foundation.DateTime> HardwareDRMDisabledUntilTime { [MethodImpl] get; }

    /// <summary>Explicitly resets any temporary disablement of hardware digital rights management (DRM), if any.</summary>
    [MethodImpl]
    public static extern void ResetHardwareDRMDisabled();

    /// <summary>Gets the PlayReady Trusted Input activation string.</summary>
    /// <returns>The PlayReady Trusted Input activation string. This string is used by the Media Protection Manager to tell the media source which Input Trust Authority (ITA) to create.</returns>
    public static extern string InputTrustAuthorityToCreate { [MethodImpl] get; }

    /// <summary>Gets the PlayReady content protection system ID inside a PSSH box.</summary>
    /// <returns>Specifies the PlayReady content protection system ID inside a PSSH box. This parameter is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid ProtectionSystemId { [MethodImpl] get; }

    /// <summary>Gets the type of a PlayReady secure stop service request.</summary>
    /// <returns>The type of a PlayReady secure stop service request. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid SecureStopServiceRequestType { [MethodImpl] get; }

    /// <summary>Queries whether the specified hardware digital rights management (DRM) feature is supported on the system.</summary>
    /// <param name="hwdrmFeature">The hardware DRM feature to query.</param>
    /// <returns>**true** if the hardware DRM feature is supported, otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool CheckSupportedHardware(PlayReadyHardwareDRMFeatures hwdrmFeature);

    /// <summary>Gets the current certificate security level.</summary>
    /// <returns>The current certificate security level. If not individualized or provisioned, this property returns zero (0).</returns>
    public static extern uint PlayReadyCertificateSecurityLevel { [MethodImpl] get; }

    /// <summary>Gets the type of a PlayReady domain join service request.</summary>
    /// <returns>The type of a PlayReady domain join service request. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid DomainJoinServiceRequestType { [MethodImpl] get; }

    /// <summary>Gets the type of a PlayReady domain leave service request.</summary>
    /// <returns>The type of a PlayReady domain leave service request. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid DomainLeaveServiceRequestType { [MethodImpl] get; }

    /// <summary>Gets the type of a PlayReady individualization service request.</summary>
    /// <returns>The type of a PlayReady individualization service request. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid IndividualizationServiceRequestType { [MethodImpl] get; }

    /// <summary>Gets the type of a PlayReady license acquisition service request.</summary>
    /// <returns>The type of a PlayReady license acquisition service request. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid LicenseAcquirerServiceRequestType { [MethodImpl] get; }

    /// <summary>Gets the type of a PlayReady metering service request.</summary>
    /// <returns>The type of a PlayReady metering service request. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid MeteringReportServiceRequestType { [MethodImpl] get; }

    /// <summary>Gets the type of a PlayReady revocation service request.</summary>
    /// <returns>The type of a PlayReady revocation service request. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid RevocationServiceRequestType { [MethodImpl] get; }

    /// <summary>Gets the PlayReady media protection system identifier.</summary>
    /// <returns>The PlayReady media protection system identifier. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public static extern Guid MediaProtectionSystemId { [MethodImpl] get; }

    /// <summary>Gets the PlayReady runtime security version.</summary>
    /// <returns>The PlayReady runtime security version.</returns>
    public static extern uint PlayReadySecurityVersion { [MethodImpl] get; }
  }
}
