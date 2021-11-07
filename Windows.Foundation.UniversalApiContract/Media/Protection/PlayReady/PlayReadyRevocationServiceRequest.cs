// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyRevocationServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Updates the revocation data required by PlayReady.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyRevocationServiceRequest : 
    IPlayReadyRevocationServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    /// <summary>Initializes a new instance of the PlayReadyRevocationServiceRequest class.</summary>
    [MethodImpl]
    public extern PlayReadyRevocationServiceRequest();

    /// <summary>Gets or sets the URI used to perform a service request action. This property is not supported in this class.</summary>
    /// <returns>Get always returns **NULL** data. Set always returns 0x80070032 (the request is not supported).</returns>
    public extern global::Windows.Foundation.Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the custom data that was returned in the response from the service. This property is not supported in this class.</summary>
    /// <returns>Always returns **NULL** data.</returns>
    public extern string ResponseCustomData { [MethodImpl] get; }

    /// <summary>Gets or sets the custom data of the request challenge. This property is not supported in this class.</summary>
    /// <returns>Get always returns **NULL** data. Set always returns 0x80070032 (the request is not supported).</returns>
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

    /// <summary>Begins the process of manually enabling. This method is not supported in this class.</summary>
    /// <returns>This method always returns 0x80070032 (the request is not supported).</returns>
    [MethodImpl]
    public extern PlayReadySoapMessage GenerateManualEnablingChallenge();

    /// <summary>Process the raw binary result of a manual enabling challenge. This method is not supported in this class.</summary>
    /// <param name="responseBytes">The response result to be processed.</param>
    /// <returns>This method always returns 0x80070032 (the request is not supported).</returns>
    [MethodImpl]
    public extern HResult ProcessManualEnablingResponse([Range(0, 2147483647)] byte[] responseBytes);

    /// <summary>Gets the vendor content protection system identifier.</summary>
    /// <returns>The vendor content protection system identifier. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid ProtectionSystem { [MethodImpl] get; }

    /// <summary>Gets the GUID for the type of operation that the PlayReady revocation service request performs.</summary>
    /// <returns>The GUID for the type of operation. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid Type { [MethodImpl] get; }
  }
}
