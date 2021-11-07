// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicenseAcquisitionServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides the service methods for obtaining PlayReady licenses.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyLicenseAcquisitionServiceRequest : 
    IPlayReadyLicenseAcquisitionServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest,
    IPlayReadyLicenseAcquisitionServiceRequest2,
    IPlayReadyLicenseAcquisitionServiceRequest3
  {
    /// <summary>Initializes a new instance of the PlayReadyLicenseAcquisitionServiceRequest class.</summary>
    [MethodImpl]
    public extern PlayReadyLicenseAcquisitionServiceRequest();

    /// <summary>Gets or sets the current content header property.</summary>
    /// <returns>The current content header property.</returns>
    public extern PlayReadyContentHeader ContentHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current domain service identifier property that overrides a service identifier in the content header.</summary>
    /// <returns>The current domain service identifier property. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid DomainServiceId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the URI used to perform a service request action.</summary>
    /// <returns>The URI to be used.</returns>
    public extern global::Windows.Foundation.Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the custom data that was returned in the response from the service.</summary>
    /// <returns>The custom data.</returns>
    public extern string ResponseCustomData { [MethodImpl] get; }

    /// <summary>Gets or sets the custom data of the request challenge.</summary>
    /// <returns>The custom data.</returns>
    public extern string ChallengeCustomData { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Begins an asynchronous service request operation.</summary>
    /// <returns>The asynchronous service action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BeginServiceRequest();

    /// <summary>Returns a new service request interface.</summary>
    /// <returns>The new service request interface.</returns>
    [MethodImpl]
    public extern IPlayReadyServiceRequest NextServiceRequest();

    /// <summary>Begins the process of manually enabling.</summary>
    /// <returns>The SOAP message to be used in a manual license acquisition challenge request.</returns>
    [MethodImpl]
    public extern PlayReadySoapMessage GenerateManualEnablingChallenge();

    /// <summary>Process the raw binary result of a manual enabling challenge.</summary>
    /// <param name="responseBytes">The response result to be processed.</param>
    /// <returns>If the methods succeeds, it returns S_OK. If it fails, it returns an error code.</returns>
    [MethodImpl]
    public extern HResult ProcessManualEnablingResponse([Range(0, 2147483647)] byte[] responseBytes);

    /// <summary>Gets the vendor content protection system identifier.</summary>
    /// <returns>The vendor content protection system identifier. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid ProtectionSystem { [MethodImpl] get; }

    /// <summary>Gets the GUID for the type of operation that the PlayReady license acquisition service request performs.</summary>
    /// <returns>The GUID for the type of operation. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid Type { [MethodImpl] get; }

    /// <summary>Gets a unique identifier for the PlayReady license acquisition operation.</summary>
    /// <returns>A unique identifier for the PlayReady license acquisition operation.</returns>
    public extern Guid SessionId { [MethodImpl] get; }

    /// <summary>Creates a PlayReadyLicense class iterator that supports in-memory-only PlayReady licenses in addition to persisted licenses.</summary>
    /// <param name="contentHeader">The content header used to locate associated licenses.</param>
    /// <param name="fullyEvaluated">Indicates whether evaluated license chains should be enumerated or if all licenses (including those that are unusable) should be enumerated. Set this parameter to true if evaluated license chains should be enumerated. Set this parameter to false if all licenses should be enumerated.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern PlayReadyLicenseIterable CreateLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
