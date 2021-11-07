// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPco
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class representing a Protocol Configuration Options information element (PCO). The purpose of a PCO is, during a packet data protocol (PDP) context activation, to transfer the external network protocol options associated with the activation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class MobileBroadbandPco : IMobileBroadbandPco
  {
    /// <summary>From the modem, gets the details of the protocol configuration options (PCO) as set by you as the mobile network operator (MNO). Your MNO app should be able to understand this payload. It should decode the data, and control the modem accordingly (for example, turn off the radio, or isolate the modem).</summary>
    /// <returns>A buffer containing the details of the protocol configuration options (PCO).</returns>
    public extern IBuffer Data { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the data received from the modem is complete, or is a subset of the Protocol Configuration Options (PCO) data structure.</summary>
    /// <returns>`true` if the data is complete; `false` if it's a subset of the Protocol Configuration Options (PCO) data structure.</returns>
    public extern bool IsComplete { [MethodImpl] get; }

    /// <summary>Gets the DeviceInformation Id of the mobile broadband device.</summary>
    /// <returns>A device information identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }
  }
}
