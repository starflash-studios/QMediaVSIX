// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Creates PlayReady-ND sessions, coordinates with the download engine and the stream parser (for example, an MPEG-2 demuxer), manages the sample buffer, and listens to media stream source events.</summary>
  /// <deprecated type="deprecate">NDClient is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Activatable(typeof (INDClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("NDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NDClient : INDClient
  {
    /// <summary>Creates a new instance of the NDClient class.</summary>
    /// <deprecated type="deprecate">INDClientFactory is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="downloadEngine">The download engine used to stream protected media content from a transmitter.</param>
    /// <param name="streamParser">The stream parser used to parse data from a media stream.</param>
    /// <param name="pMessenger">The messenger used to send messages between the PlayReady-ND receiver and transmitter.</param>
    [Deprecated("INDClientFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDClient(
      INDDownloadEngine downloadEngine,
      INDStreamParser streamParser,
      INDMessenger pMessenger);

    /// <summary>Notifies listeners that a registration operation has completed.</summary>
    public extern event TypedEventHandler<NDClient, INDRegistrationCompletedEventArgs> RegistrationCompleted;

    /// <summary>Notifies listeners that a proximity detection operation has completed.</summary>
    public extern event TypedEventHandler<NDClient, INDProximityDetectionCompletedEventArgs> ProximityDetectionCompleted;

    /// <summary>Notifies listeners that a license fetch operation has completed.</summary>
    public extern event TypedEventHandler<NDClient, INDLicenseFetchCompletedEventArgs> LicenseFetchCompleted;

    /// <summary>Notifies listeners that the app should start re-registration by calling the ReRegistrationAsync method.</summary>
    public extern event TypedEventHandler<NDClient, object> ReRegistrationNeeded;

    /// <summary>Notifies listeners that a closed caption acquisition operation has completed.</summary>
    public extern event TypedEventHandler<NDClient, INDClosedCaptionDataReceivedEventArgs> ClosedCaptionDataReceived;

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<INDStartResult> StartAsync(
      Uri contentUrl,
      uint startAsyncOptions,
      INDCustomData registrationCustomData,
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    /// <summary>Performs a license fetch between a client receiver and a transmitter.</summary>
    /// <deprecated type="deprecate">INDClient is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="licenseFetchDescriptor">Descriptor for the license being fetched.</param>
    /// <returns>The result of the asynchronous license fetch call.</returns>
    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<INDLicenseFetchResult> LicenseFetchAsync(
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    /// <summary>Performs a proximity detection and reregistration between a client receiver and a transmitter.</summary>
    /// <deprecated type="deprecate">INDClient is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="registrationCustomData">Custom data for the registration request.</param>
    /// <returns>The result of the asynchronous reregistration call.</returns>
    [RemoteAsync]
    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction ReRegistrationAsync(INDCustomData registrationCustomData);

    /// <summary>Closes the current playback session regardless of whether it is in the registration, proximity detection, license fetch, or play state.</summary>
    /// <deprecated type="deprecate">INDClient is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Close();
  }
}
