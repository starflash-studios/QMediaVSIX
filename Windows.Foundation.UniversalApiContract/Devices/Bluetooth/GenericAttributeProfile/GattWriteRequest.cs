// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class represents a GATT write request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattWriteRequest : IGattWriteRequest
  {
    /// <summary>Gets the buffer value of the write request.</summary>
    /// <returns>The buffer value of the write request.</returns>
    public extern IBuffer Value { [MethodImpl] get; }

    /// <summary>Gets the offset.</summary>
    /// <returns>The offset.</returns>
    public extern uint Offset { [MethodImpl] get; }

    /// <summary>Gets the write request option.</summary>
    /// <returns>The write request option.</returns>
    public extern GattWriteOption Option { [MethodImpl] get; }

    /// <summary>Gets the state of the write request.</summary>
    /// <returns>The state of the write request.</returns>
    public extern GattRequestState State { [MethodImpl] get; }

    /// <summary>An event that is triggered when the state of the write request has changed.</summary>
    public extern event TypedEventHandler<GattWriteRequest, GattRequestStateChangedEventArgs> StateChanged;

    /// <summary>Responds to the write request.</summary>
    [MethodImpl]
    public extern void Respond();

    /// <summary>Responds with a protocol error.</summary>
    /// <param name="protocolError">The GATT protocol error.</param>
    [MethodImpl]
    public extern void RespondWithProtocolError(byte protocolError);
  }
}
