// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedMagneticStripeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1197254899, 37911, 18620, 185, 215, 65, 99, 167, 132, 76, 2)]
  [ExclusiveTo(typeof (ClaimedMagneticStripeReader))]
  internal interface IClaimedMagneticStripeReader
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    bool IsDisabledOnDataReceived { set; get; }

    bool IsDecodeDataEnabled { set; get; }

    bool IsDeviceAuthenticated { get; }

    uint DataEncryptionAlgorithm { set; get; }

    MagneticStripeReaderTrackIds TracksToRead { set; get; }

    bool IsTransmitSentinelsEnabled { set; get; }

    [RemoteAsync]
    IAsyncAction EnableAsync();

    [RemoteAsync]
    IAsyncAction DisableAsync();

    void RetainDevice();

    void SetErrorReportingType(MagneticStripeReaderErrorReportingType value);

    [RemoteAsync]
    IAsyncOperation<IBuffer> RetrieveDeviceAuthenticationDataAsync();

    [RemoteAsync]
    IAsyncAction AuthenticateDeviceAsync(byte[] responseToken);

    [RemoteAsync]
    IAsyncAction DeAuthenticateDeviceAsync(byte[] responseToken);

    [RemoteAsync]
    IAsyncAction UpdateKeyAsync(string key, string keyName);

    [RemoteAsync]
    IAsyncAction ResetStatisticsAsync(IIterable<string> statisticsCategories);

    [RemoteAsync]
    IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderBankCardDataReceivedEventArgs> BankCardDataReceived;

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderAamvaCardDataReceivedEventArgs> AamvaCardDataReceived;

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs> VendorSpecificDataReceived;

    event EventHandler<ClaimedMagneticStripeReader> ReleaseDeviceRequested;

    event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderErrorOccurredEventArgs> ErrorOccurred;
  }
}
