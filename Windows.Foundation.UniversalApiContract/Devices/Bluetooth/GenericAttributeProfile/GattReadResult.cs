// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents the result of an asynchronous read operation of a GATT Characteristic or Descriptor value.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattReadResult : IGattReadResult, IGattReadResult2
  {
    /// <summary>Gets the status of an asynchronous operation.</summary>
    /// <returns>The status of the asynchronous operation.</returns>
    public extern GattCommunicationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the value read from the device.</summary>
    /// <returns>The value read from the device.</returns>
    public extern IBuffer Value { [MethodImpl] get; }

    /// <summary>Gets the protocol error.</summary>
    /// <returns>The protocol error.</returns>
    public extern IReference<byte> ProtocolError { [MethodImpl] get; }
  }
}
