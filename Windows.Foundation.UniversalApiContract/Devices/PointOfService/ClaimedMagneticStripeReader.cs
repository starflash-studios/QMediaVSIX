// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedMagneticStripeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the claimed magnetic stripe reader.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ClaimedMagneticStripeReader : 
    IClaimedMagneticStripeReader,
    IClaimedMagneticStripeReader2,
    IClosable
  {
    /// <summary>Gets the DeviceInformation.Id of the claimed magnetic stripe reader.</summary>
    /// <returns>The DeviceInformation.Id of the claimed magnetic stripe reader.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Indicates whether the magnetic stripe reader is ready to receive data events.</summary>
    /// <returns>True if the device is operational; otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value that indicates whether the magnetic stripe reader is disabled after receiving the data from the most recently swiped card.</summary>
    /// <returns>Set to true if the application wants to receive and process only one input or only one input at a time.</returns>
    public extern bool IsDisabledOnDataReceived { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates whether to provide raw or decoded data from the most recently swiped card.</summary>
    /// <returns>Set to true if decoded data is provided to the application; otherwise, false.</returns>
    public extern bool IsDecodeDataEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates whether the device is authenticated.</summary>
    /// <returns>True is the device is authenticated; otherwise, false.</returns>
    public extern bool IsDeviceAuthenticated { [MethodImpl] get; }

    /// <summary>Gets or sets the MagneticStripeReaderEncryptionAlgorithms that will be used to encrypt the track data.</summary>
    /// <returns>The encryption algorithm the will be used to encrypt the track data.</returns>
    public extern uint DataEncryptionAlgorithm { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the track data that the application wants to receive following a card swipe.</summary>
    /// <returns>The card track.</returns>
    public extern MagneticStripeReaderTrackIds TracksToRead { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates whether the track data contains start and end sentinel values.</summary>
    /// <returns>True if the track data contains start and end sentinel values. False if the track data properties only contain track data between sentinels.</returns>
    public extern bool IsTransmitSentinelsEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the magnetic stripe reader into a ready state to receive data events.</summary>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction EnableAsync();

    /// <summary>Puts the ClaimedMagneticStripeReader into a state where it cannot receive data events.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DisableAsync();

    /// <summary>Retains exclusive claim to the magnetic stripe reader.</summary>
    [MethodImpl]
    public extern void RetainDevice();

    /// <summary>Sets the type of error to report by the ErrorOccurred event.</summary>
    /// <param name="value">Error reporting type.</param>
    [MethodImpl]
    public extern void SetErrorReportingType(MagneticStripeReaderErrorReportingType value);

    /// <summary>Retrieves a challenge token from the device.</summary>
    /// <returns>Buffer used to store the resulting challenge token from the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> RetrieveDeviceAuthenticationDataAsync();

    /// <summary>Puts the device into an authenticated state.</summary>
    /// <param name="responseToken">A buffer containing the response token generated from the challenge token retrieved from a previous call to the RetrieveDeviceAuthenticationDataAsync method.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AuthenticateDeviceAsync(byte[] responseToken);

    /// <summary>Puts the device into an unauthenticated state.</summary>
    /// <param name="responseToken">A buffer containing the response token generated from the challenge token retrieved from a previous call to the RetrieveDeviceAuthenticationDataAsync method.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeAuthenticateDeviceAsync(byte[] responseToken);

    /// <summary>Provides a new encryption key to the device.</summary>
    /// <param name="key">The HEX-ASCII or base64-encoded value for the new key.</param>
    /// <param name="keyName">The name used to identify the key.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateKeyAsync(string key, string keyName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResetStatisticsAsync(
      IIterable<string> statisticsCategories);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    /// <summary>Occurs when a bank card is swiped.</summary>
    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderBankCardDataReceivedEventArgs> BankCardDataReceived;

    /// <summary>Occurs when a motor vehicle card is swiped.</summary>
    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderAamvaCardDataReceivedEventArgs> AamvaCardDataReceived;

    /// <summary>Occurs when a vendor-specific card is swiped.</summary>
    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs> VendorSpecificDataReceived;

    /// <summary>Occurs when the device gets a request to release its exclusive claim.</summary>
    public extern event EventHandler<ClaimedMagneticStripeReader> ReleaseDeviceRequested;

    /// <summary>Occurs when the magnetic stripe reader detects an error when reading a card.</summary>
    public extern event TypedEventHandler<ClaimedMagneticStripeReader, MagneticStripeReaderErrorOccurredEventArgs> ErrorOccurred;

    /// <summary>Event that is raised when the **ClaimedMagneticStripeReader** is closed.</summary>
    public extern event TypedEventHandler<ClaimedMagneticStripeReader, ClaimedMagneticStripeReaderClosedEventArgs> Closed;

    [MethodImpl]
    public extern void Close();
  }
}
