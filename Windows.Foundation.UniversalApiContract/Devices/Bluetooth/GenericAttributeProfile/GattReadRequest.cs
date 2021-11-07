// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class represents a Bluetooth GATT read request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattReadRequest : IGattReadRequest
  {
    /// <summary>Gets the read request offset.</summary>
    /// <returns>The read request offset.</returns>
    public extern uint Offset { [MethodImpl] get; }

    /// <summary>Gets the buffer length of the read request.</summary>
    /// <returns>The buffer length of the read request.</returns>
    public extern uint Length { [MethodImpl] get; }

    /// <summary>Gets the read request state.</summary>
    /// <returns>The read request state.</returns>
    public extern GattRequestState State { [MethodImpl] get; }

    /// <summary>This is an event that is triggered when the read request state was changed.</summary>
    public extern event TypedEventHandler<GattReadRequest, GattRequestStateChangedEventArgs> StateChanged;

    /// <summary>Responds to a read request with a value.</summary>
    /// <param name="value">The value to respond with.</param>
    [MethodImpl]
    public extern void RespondWithValue(IBuffer value);

    /// <summary>Responds to the read request with a protocol error.</summary>
    /// <param name="protocolError">The protocol error to send. A list of errors with the byte values can be found in GattProtocolError.</param>
    [MethodImpl]
    public extern void RespondWithProtocolError(byte protocolError);
  }
}
