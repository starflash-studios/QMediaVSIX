// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.RfcommServiceProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  /// <summary>Represents an instance of a local RFCOMM service.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRfcommServiceProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  public sealed class RfcommServiceProvider : IRfcommServiceProvider, IRfcommServiceProvider2
  {
    /// <summary>Gets the RfcommServiceId of this local RFCOMM service instance.</summary>
    /// <returns>The RfcommServiceId of the local RFCOMM service instance.</returns>
    public extern RfcommServiceId ServiceId { [MethodImpl] get; }

    /// <summary>Gets a collection of SDP attributes for advertising.</summary>
    /// <returns>The collection of SDP attributes for advertising.</returns>
    public extern IMap<uint, IBuffer> SdpRawAttributes { [MethodImpl] get; }

    /// <summary>Begins advertising the SDP attributes.</summary>
    /// <param name="listener">The StreamSocketListener that is listening for incoming connections.</param>
    [MethodImpl]
    public extern void StartAdvertising(StreamSocketListener listener);

    /// <summary>Stops advertising the SDP attributes.</summary>
    [MethodImpl]
    public extern void StopAdvertising();

    /// <summary>Begins advertising the SDP attributes.</summary>
    /// <param name="listener">The StreamSocketListener that is listening for incoming connections.</param>
    /// <param name="radioDiscoverable">Indicates whether the radio is discoverable (true) or not (false).</param>
    [Overload("StartAdvertisingWithRadioDiscoverability")]
    [MethodImpl]
    public extern void StartAdvertising(StreamSocketListener listener, bool radioDiscoverable);

    /// <summary>Gets a RfcommServiceProvider object from a DeviceInformation Id for a RFCOMM service instance.</summary>
    /// <param name="serviceId">The RfcommServiceId to be hosted locally.</param>
    /// <returns>The RfcommServiceProvider object that represents the local RFCOMM service instance.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RfcommServiceProvider> CreateAsync(
      RfcommServiceId serviceId);
  }
}
