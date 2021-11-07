// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IProximityDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (ProximityDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4020806994, 63201, 17193, 160, 252, 171, 107, 15, 210, 130, 98)]
  internal interface IProximityDevice
  {
    long SubscribeForMessage(string messageType, MessageReceivedHandler messageReceivedHandler);

    [Overload("PublishMessage")]
    long PublishMessage(string messageType, string message);

    [Overload("PublishMessageWithCallback")]
    long PublishMessage(
      string messageType,
      string message,
      MessageTransmittedHandler messageTransmittedHandler);

    [Overload("PublishBinaryMessage")]
    long PublishBinaryMessage(string messageType, IBuffer message);

    [Overload("PublishBinaryMessageWithCallback")]
    long PublishBinaryMessage(
      string messageType,
      IBuffer message,
      MessageTransmittedHandler messageTransmittedHandler);

    [Overload("PublishUriMessage")]
    long PublishUriMessage(Uri message);

    [Overload("PublishUriMessageWithCallback")]
    long PublishUriMessage(
      Uri message,
      MessageTransmittedHandler messageTransmittedHandler);

    void StopSubscribingForMessage(long subscriptionId);

    void StopPublishingMessage(long messageId);

    event DeviceArrivedEventHandler DeviceArrived;

    event DeviceDepartedEventHandler DeviceDeparted;

    uint MaxMessageBytes { get; }

    ulong BitsPerSecond { get; }

    string DeviceId { get; }
  }
}
