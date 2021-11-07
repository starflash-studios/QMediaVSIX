// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a device service data session which allows the caller to write data to the modem on a mobile broadband device service.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandDeviceServiceDataSession : 
    IMobileBroadbandDeviceServiceDataSession
  {
    /// <summary>Starts an asynchronous operation on a mobile broadband device service to write data to the data session.</summary>
    /// <param name="value">The data to be submitted as part of the write operation.</param>
    /// <returns>An asynchronous operation that returns the result of the write operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction WriteDataAsync(IBuffer value);

    /// <summary>Closes the data session on a mobile broadband device service.</summary>
    [MethodImpl]
    public extern void CloseSession();

    /// <summary>An event that indicates that data was received on the MobileBroadbandDeviceServiceDataSession object after the WriteDataAsync method was called.</summary>
    public extern event TypedEventHandler<MobileBroadbandDeviceServiceDataSession, MobileBroadbandDeviceServiceDataReceivedEventArgs> DataReceived;
  }
}
