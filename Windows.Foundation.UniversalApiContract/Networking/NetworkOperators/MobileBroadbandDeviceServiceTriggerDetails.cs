// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides details for a network device service notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class MobileBroadbandDeviceServiceTriggerDetails : 
    IMobileBroadbandDeviceServiceTriggerDetails
  {
    /// <summary>Gets the device ID of the device that triggered a broadband device service event.</summary>
    /// <returns>The unique device identifier for the triggering event.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the device service identifier for the device service trigger event.</summary>
    /// <returns>The unique device service identifier for the triggering event.</returns>
    public extern Guid DeviceServiceId { [MethodImpl] get; }

    /// <summary>Gets the received data associated with the triggered event.</summary>
    /// <returns>The data associated with the triggered event. Data format is dependent upon the protocols of the specific device service.</returns>
    public extern IBuffer ReceivedData { [MethodImpl] get; }
  }
}
