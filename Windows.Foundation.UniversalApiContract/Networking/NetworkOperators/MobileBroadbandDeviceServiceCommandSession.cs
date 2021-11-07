// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a device service command session which allows the caller to submit predefined commands to the modem on a mobile broadband device service.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandDeviceServiceCommandSession : 
    IMobileBroadbandDeviceServiceCommandSession
  {
    /// <summary>Starts an asynchronous operation on a mobile broadband device service to send a query command to the command session.</summary>
    /// <param name="commandId">The command identifier for the query command to be executed.</param>
    /// <param name="data">The data to be submitted as part of the command.</param>
    /// <returns>An asynchronous operation that returns the result of the command.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> SendQueryCommandAsync(
      uint commandId,
      IBuffer data);

    /// <summary>Starts an asynchronous operation on a mobile broadband device service to send a set command to the command session.</summary>
    /// <param name="commandId">The command identifier for the set command to be executed.</param>
    /// <param name="data">The data to be submitted as part of the command.</param>
    /// <returns>An asynchronous operation that returns the result of the command.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> SendSetCommandAsync(
      uint commandId,
      IBuffer data);

    /// <summary>Closes the command session on a mobile broadband device service.</summary>
    [MethodImpl]
    public extern void CloseSession();
  }
}
