// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Base interface for all service request interfaces.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2343381046, 42755, 17830, 161, 128, 118, 243, 86, 90, 167, 37)]
  public interface IPlayReadyServiceRequest : IMediaProtectionServiceRequest
  {
    /// <summary>Gets or sets the URI used to perform a service request action.</summary>
    /// <returns>The URI to be used.</returns>
    Uri Uri { get; set; }

    /// <summary>Gets the custom data that was returned in the response from the service.</summary>
    /// <returns>The custom data.</returns>
    string ResponseCustomData { get; }

    /// <summary>Gets or sets the custom data of the request challenge.</summary>
    /// <returns>The custom data.</returns>
    string ChallengeCustomData { get; set; }

    /// <summary>Begins an asynchronous service request operation.</summary>
    /// <returns>The asynchronous service action.</returns>
    [RemoteAsync]
    IAsyncAction BeginServiceRequest();

    /// <summary>Returns a new service request interface.</summary>
    /// <returns>The new service request interface.</returns>
    IPlayReadyServiceRequest NextServiceRequest();

    /// <summary>Begins the process of manually enabling.</summary>
    /// <returns>Begins the process of manually enabling.</returns>
    PlayReadySoapMessage GenerateManualEnablingChallenge();

    /// <summary>Processes the raw binary result of a manual enabling challenge.</summary>
    /// <param name="responseBytes">The response result to be processed.</param>
    /// <returns>If the methods succeeds, it returns S_OK. If it fails, it returns an error code.</returns>
    HResult ProcessManualEnablingResponse([Range(0, 2147483647)] byte[] responseBytes);
  }
}
