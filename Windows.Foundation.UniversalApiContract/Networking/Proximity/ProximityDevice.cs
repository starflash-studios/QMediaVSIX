// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.ProximityDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  /// <summary>Enables you to publish messages to proximate devices or subscribe to messages from proximate devices.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IProximityDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ProximityDevice : IProximityDevice
  {
    /// <summary>Creates a subscription for a specified message type.</summary>
    /// <param name="messageType">The type of message to deliver to this subscription.</param>
    /// <param name="messageReceivedHandler">The handler that the proximity provider will call when it delivers a message.</param>
    /// <returns>A unique ID for the subscription.</returns>
    [MethodImpl]
    public extern long SubscribeForMessage(
      string messageType,
      MessageReceivedHandler messageReceivedHandler);

    /// <summary>Publishes a message to subscribers of the specified message type.</summary>
    /// <param name="messageType">The type of message to deliver to subscribers.</param>
    /// <param name="message">The message to deliver to subscribers.</param>
    /// <returns>A unique publication ID for the published message. Pass this value to the StopPublishingMessage method to stop publishing the message.</returns>
    [Overload("PublishMessage")]
    [MethodImpl]
    public extern long PublishMessage(string messageType, string message);

    /// <summary>Publishes a message to subscribers of the specified message type. The specified handler is called when the message has been transmitted.</summary>
    /// <param name="messageType">The type of message to deliver to subscribers.</param>
    /// <param name="message">The message to deliver to subscribers.</param>
    /// <param name="messageTransmittedHandler">The handler to call when the message has been transmitted.</param>
    /// <returns>A unique publication ID for the published message.</returns>
    [Overload("PublishMessageWithCallback")]
    [MethodImpl]
    public extern long PublishMessage(
      string messageType,
      string message,
      MessageTransmittedHandler messageTransmittedHandler);

    /// <summary>Publishes to subscribers of the specified message type a message that contains binary data.</summary>
    /// <param name="messageType">The type of message to deliver to subscribers.</param>
    /// <param name="message">The binary message data to deliver to subscribers.</param>
    /// <returns>A unique publication ID for the published message.</returns>
    [Overload("PublishBinaryMessage")]
    [MethodImpl]
    public extern long PublishBinaryMessage(string messageType, IBuffer message);

    /// <summary>Publishes a message that contains binary data to subscribers of the specified message type. The specified handler is called when the message has been transmitted.</summary>
    /// <param name="messageType">The type of message to deliver to subscribers.</param>
    /// <param name="message">The binary message data to deliver to subscribers.</param>
    /// <param name="messageTransmittedHandler">The handler to call when the message has been transmitted.</param>
    /// <returns>A unique publication ID for the published message.</returns>
    [Overload("PublishBinaryMessageWithCallback")]
    [MethodImpl]
    public extern long PublishBinaryMessage(
      string messageType,
      IBuffer message,
      MessageTransmittedHandler messageTransmittedHandler);

    [Overload("PublishUriMessage")]
    [MethodImpl]
    public extern long PublishUriMessage(Uri message);

    [Overload("PublishUriMessageWithCallback")]
    [MethodImpl]
    public extern long PublishUriMessage(
      Uri message,
      MessageTransmittedHandler messageTransmittedHandler);

    /// <summary>Cancels a message subscription.</summary>
    /// <param name="subscriptionId">The subscription ID for the message.</param>
    [MethodImpl]
    public extern void StopSubscribingForMessage(long subscriptionId);

    /// <summary>Stops publishing a message.</summary>
    /// <param name="messageId">The publication ID for the message.</param>
    [MethodImpl]
    public extern void StopPublishingMessage(long messageId);

    /// <summary>Occurs when a device enters the proximate range.</summary>
    public extern event DeviceArrivedEventHandler DeviceArrived;

    /// <summary>Occurs when a device leaves the proximate range.</summary>
    public extern event DeviceDepartedEventHandler DeviceDeparted;

    /// <summary>Gets the maximum size of a published message that this proximity device supports.</summary>
    /// <returns>The maximum size of a published message that this proximity device supports.</returns>
    public extern uint MaxMessageBytes { [MethodImpl] get; }

    /// <summary>Gets the transfer rate of a proximity device.</summary>
    /// <returns>The transfer rate of a proximity device.</returns>
    public extern ulong BitsPerSecond { [MethodImpl] get; }

    /// <summary>Gets the DeviceInformation Id for a proximity device.</summary>
    /// <returns>The DeviceInformation Id for a proximity device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Returns the class selection string that you can use to enumerate proximity devices.</summary>
    /// <returns>The class selection string for proximity devices.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Creates an instance of a ProximityDevice class and activates the default proximity provider.</summary>
    /// <returns>A new proximity device that uses the default proximity provider. Returns **NULL** if no proximity devices are installed.</returns>
    [MethodImpl]
    public static extern ProximityDevice GetDefault();

    /// <summary>Creates an instance of a ProximityDevice class and activates the specified proximity device interface.</summary>
    /// <param name="deviceId">The DeviceInformation Id of a proximity device.</param>
    /// <returns>A new ProximityDevice that uses the specified proximity device interface. Throws a **System.IO.FileNotFoundException** exception if the specified proximity device interface isunavailable.</returns>
    [MethodImpl]
    public static extern ProximityDevice FromId(string deviceId);
  }
}
