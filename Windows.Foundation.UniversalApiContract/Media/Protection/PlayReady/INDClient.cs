// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (NDClient))]
  [Guid(1003911195, 25016, 18146, 153, 165, 138, 188, 182, 185, 247, 214)]
  internal interface INDClient
  {
    event TypedEventHandler<NDClient, INDRegistrationCompletedEventArgs> RegistrationCompleted;

    event TypedEventHandler<NDClient, INDProximityDetectionCompletedEventArgs> ProximityDetectionCompleted;

    event TypedEventHandler<NDClient, INDLicenseFetchCompletedEventArgs> LicenseFetchCompleted;

    event TypedEventHandler<NDClient, object> ReRegistrationNeeded;

    event TypedEventHandler<NDClient, INDClosedCaptionDataReceivedEventArgs> ClosedCaptionDataReceived;

    [RemoteAsync]
    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<INDStartResult> StartAsync(
      Uri contentUrl,
      uint startAsyncOptions,
      INDCustomData registrationCustomData,
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<INDLicenseFetchResult> LicenseFetchAsync(
      INDLicenseFetchDescriptor licenseFetchDescriptor);

    [RemoteAsync]
    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction ReRegistrationAsync(INDCustomData registrationCustomData);

    [Deprecated("INDClient is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Close();
  }
}
