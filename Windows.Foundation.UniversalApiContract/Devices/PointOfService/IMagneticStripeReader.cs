// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Guid(445820949, 18371, 18058, 147, 51, 12, 101, 23, 87, 72, 131)]
  [ExclusiveTo(typeof (MagneticStripeReader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagneticStripeReader
  {
    string DeviceId { get; }

    MagneticStripeReaderCapabilities Capabilities { get; }

    uint[] SupportedCardTypes { get; }

    MagneticStripeReaderAuthenticationProtocol DeviceAuthenticationProtocol { get; }

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<ClaimedMagneticStripeReader> ClaimReaderAsync();

    [RemoteAsync]
    IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    MagneticStripeReaderErrorReportingType GetErrorReportingType();

    event TypedEventHandler<MagneticStripeReader, MagneticStripeReaderStatusUpdatedEventArgs> StatusUpdated;
  }
}
