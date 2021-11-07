// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattReliableWriteTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Performs GATT reliable writes on the Bluetooth LE device, in the form of a transaction write operation.</summary>
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattReliableWriteTransaction : 
    IGattReliableWriteTransaction,
    IGattReliableWriteTransaction2
  {
    /// <summary>Creates a new GattReliableWriteTransaction object.</summary>
    [MethodImpl]
    public extern GattReliableWriteTransaction();

    /// <summary>Adds a new write operation to the transaction object.</summary>
    /// <param name="characteristic">The GattCharacteristic object on which to perform the write operation.</param>
    /// <param name="value">The Characteristic Value to be written to characteristic.</param>
    [MethodImpl]
    public extern void WriteValue(GattCharacteristic characteristic, IBuffer value);

    /// <summary>Performs all the queued writes, in sequence, writing the data to the device. Once a transaction object has been committed, no further operations are possible on the GattReliableWriteTransaction object.</summary>
    /// <returns>The object used to manage the asynchronous operation, which, upon completion, will return the status of the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> CommitAsync();

    /// <summary>Performs all the queued writes, in sequence, writing the data to the device. Once a transaction object has been committed, no further operations are possible on the GattReliableWriteTransaction object.</summary>
    /// <returns>An asynchronous operation that completes with a GattWriteResult object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> CommitWithResultAsync();
  }
}
