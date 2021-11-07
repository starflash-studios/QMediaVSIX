// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadySecureStopServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Manages secure stop messages.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPlayReadySecureStopServiceRequestFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadySecureStopServiceRequest : 
    IPlayReadySecureStopServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    /// <summary>Initializes a new instance of the PlayReadySecureStopServiceRequest class to include all secure stop sessions.</summary>
    /// <param name="publisherCertBytes">The raw binary body of the publisher certificate.</param>
    [MethodImpl]
    public extern PlayReadySecureStopServiceRequest([Range(0, 2147483647)] byte[] publisherCertBytes);

    /// <summary>Initializes a new instance of the PlayReadySecureStopServiceRequest class for the specified secure stop session.</summary>
    /// <param name="sessionID">The secure stop session identifier.</param>
    /// <param name="publisherCertBytes">The raw binary body of the publisher certificate.</param>
    [MethodImpl]
    public extern PlayReadySecureStopServiceRequest(Guid sessionID, [Range(0, 2147483647)] byte[] publisherCertBytes);

    /// <summary>Gets the session identifier property.</summary>
    /// <returns>Gets the session identifier property.</returns>
    public extern Guid SessionID { [MethodImpl] get; }

    /// <summary>Gets the secure stop session's start time property.</summary>
    /// <returns>The secure stop session's start time.</returns>
    public extern global::Windows.Foundation.DateTime StartTime { [MethodImpl] get; }

    /// <summary>Gets the secure stop session's update/stop time property.</summary>
    /// <returns>The secure stop session's update/stop time.</returns>
    public extern global::Windows.Foundation.DateTime UpdateTime { [MethodImpl] get; }

    /// <summary>Gets the secure stop session's stopped flag property which indicates whether the secure stop session for this request was cleanly shut down.</summary>
    /// <returns>The secure stop session's stopped flag.</returns>
    public extern bool Stopped { [MethodImpl] get; }

    /// <summary>Gets the current publisher certificate property.</summary>
    /// <returns>The raw binary body of the publisher certificate.</returns>
    public extern byte[] PublisherCertificate { [MethodImpl] get; }

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

    /// <summary>Gets the GUID for the type of operation that the PlayReady secure stop service request performs.</summary>
    /// <returns>The GUID for the type of operation. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid Type { [MethodImpl] get; }
  }
}
