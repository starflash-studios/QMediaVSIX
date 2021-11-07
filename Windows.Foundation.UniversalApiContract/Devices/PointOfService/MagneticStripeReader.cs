// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReader
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
  /// <summary>Represents the magnetic stripe reader device.</summary>
  [Static(typeof (IMagneticStripeReaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMagneticStripeReaderStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReader : IMagneticStripeReader, IClosable
  {
    /// <summary>Gets the DeviceInformation.Id of the magnetic stripe reader.</summary>
    /// <returns>The DeviceInformation.Id of the magnetic stripe reader.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the magnetic stripe reader.</summary>
    /// <returns>The capabilities of the magnetic stripe reader.</returns>
    public extern MagneticStripeReaderCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Gets the card types supported by the magnetic stripe reader.</summary>
    /// <returns>The card type identifier.</returns>
    public extern uint[] SupportedCardTypes { [MethodImpl] get; }

    /// <summary>Device authentication protocol supported by the magnetic stripe reader.</summary>
    /// <returns>The supported authentication protocol.</returns>
    public extern MagneticStripeReaderAuthenticationProtocol DeviceAuthenticationProtocol { [MethodImpl] get; }

    /// <summary>Tests the health of the magnetic stripe reader.</summary>
    /// <param name="level">The specific health check level.</param>
    /// <returns>A text description of the text result. Returns an error if the specified check level is not supported by the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    /// <summary>Attempts to get an exclusive access to the magnetic stripe reader.</summary>
    /// <returns>When the method completes, it returns a ClaimedMagneticStripeReader or it returns null if the operation fails to claim a magnetic stripe reader.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedMagneticStripeReader> ClaimReaderAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    /// <summary>Gets the error reporting type the application wants to receive.</summary>
    /// <returns>The error reporting type.</returns>
    [MethodImpl]
    public extern MagneticStripeReaderErrorReportingType GetErrorReportingType();

    /// <summary>Occurs when the device detects an operation status change.</summary>
    public extern event TypedEventHandler<MagneticStripeReader, MagneticStripeReaderStatusUpdatedEventArgs> StatusUpdated;

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the magnetic stripe readers available over the specified connection types</summary>
    /// <param name="connectionTypes">A list of the connection types to check for available magnetic stripe readers.</param>
    /// <returns>An Advanced Query Syntax (AQS) string that is used to enumerate the magnetic stripe readers available over the specified connection types</returns>
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    /// <summary>Returns the first magnetic stripe reader found.</summary>
    /// <returns>The first magnetic stripe reader found. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MagneticStripeReader> GetDefaultAsync();

    /// <summary>Creates a MagneticStripeReader object from DeviceInformation.Id.</summary>
    /// <param name="deviceId">The DeviceInformation.Id that identifies a specific magnetic stripe reader, which can be retrieved from the DeviceId property.</param>
    /// <returns>The magnetic stripe reader specified by the unique device identifier. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MagneticStripeReader> FromIdAsync(
      string deviceId);

    /// <summary>Returns an Advanced Query Syntax (AQS) string that is used to enumerate available magnetic stripe readers.</summary>
    /// <returns>An Advanced Query Syntax (AQS) string that is used to enumerate available magnetic stripe readers.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
