// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Extends the SmsDevice class, and supports the operation of a mobile broadband SMS device.</summary>
  [Static(typeof (ISmsDevice2Statics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsDevice2 : ISmsDevice2
  {
    /// <summary>Gets or sets the SMSC address of this device.</summary>
    /// <returns>A string representation of the SMSC address of this device.</returns>
    public extern string SmscAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The device ID of the device represented by this instance.</summary>
    /// <returns>String representation of the device ID.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>The parent device ID of this device.</summary>
    /// <returns>A string representation of the device ID of the parent to this device.</returns>
    public extern string ParentDeviceId { [MethodImpl] get; }

    /// <summary>Gets the phone number associated with the SMS device. The phone number can be used to associate incoming messages with the account and possibly an external storage mechanism such as an account inbox.</summary>
    /// <returns>A string representation of the account phone number.</returns>
    public extern string AccountPhoneNumber { [MethodImpl] get; }

    /// <summary>Returns the cellular class of the SMS device. The class can be used to determine which encodings are appropriate or which device limitations are in effect.</summary>
    /// <returns>An enumerated value indicating the device's cellular class.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Returns the SMS device's status, which indicates whether the device is ready, or not. It also indicates what type of problem exists if the device is not ready.</summary>
    /// <returns>An enumerated value that indicates the readiness of an SMS device to engage in cellular network traffic operations.</returns>
    public extern SmsDeviceStatus DeviceStatus { [MethodImpl] get; }

    /// <summary>Estimates the transmitted message length of the specified text message. The estimate can be useful to clients that want to give an indication of how many messages will be sent on the network to carry the text of the full message.</summary>
    /// <param name="message">A reference to the SMS text message to measure.</param>
    /// <returns>A reference to an SmsEncodedLength structure that is populated with the length information.</returns>
    [MethodImpl]
    public extern SmsEncodedLength CalculateLength(ISmsMessageBase message);

    /// <summary>Asynchronously sends a message using the SMS device. The method is asynchronous because the send operation might not occur instantaneously. The message operation object is returned immediately.</summary>
    /// <param name="message">A reference to an object that implements the ISmsMessageBase interface. The message can be in text or binary format.</param>
    /// <returns>The message operation object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmsSendMessageResult> SendMessageAndGetResultAsync(
      ISmsMessageBase message);

    /// <summary>Sets an event handler to be called when the status of the SMS device changes.</summary>
    public extern event TypedEventHandler<SmsDevice2, object> DeviceStatusChanged;

    /// <summary>Retrieves the class selection string that can be used to enumerate SMS devices.</summary>
    /// <returns>A reference to an Advanced Query Syntax (AQS) string that identifies an SMS device.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Creates an instance of SmsDevice2 for a device that received an SMS message.</summary>
    /// <param name="deviceId">A string representation of the device ID of the device that received an SMS message.</param>
    /// <returns>An instance of SmsDevice2 initialized for the device with the given ID.</returns>
    [MethodImpl]
    public static extern SmsDevice2 FromId(string deviceId);

    /// <summary>Creates an instance of SmsDevice2 associated with the default SMS device.</summary>
    /// <returns>An instance of SmsDevice2 initialized for the default SMS device.</returns>
    [MethodImpl]
    public static extern SmsDevice2 GetDefault();

    /// <summary>Creates an instance of SmsDevice2 for a device, given the device ID of the parent device.</summary>
    /// <param name="parentDeviceId">The device ID of the parent device.</param>
    /// <returns>An instance of SmsDevice2 initialized for the device with the given parent ID.</returns>
    [MethodImpl]
    public static extern SmsDevice2 FromParentId(string parentDeviceId);
  }
}
