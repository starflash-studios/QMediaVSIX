// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides data for a DataReceived event on a MobileBroadbandDeviceServiceDataSession when data is received .</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandDeviceServiceDataReceivedEventArgs : 
    IMobileBroadbandDeviceServiceDataReceivedEventArgs
  {
    /// <summary>Gets the data received on the MobileBroadbandDeviceServiceDataSession.</summary>
    /// <returns>The data received on the MobileBroadbandDeviceServiceDataSession</returns>
    public extern IBuffer ReceivedData { [MethodImpl] get; }
  }
}
