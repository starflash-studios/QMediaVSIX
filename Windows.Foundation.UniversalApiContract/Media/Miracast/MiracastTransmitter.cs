// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastTransmitter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>An object that represent a Miracast Transmitter.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MiracastTransmitter : IMiracastTransmitter
  {
    /// <summary>Returns the name of the Miracast Transmitter.</summary>
    /// <returns>The name of the Miracast Transmitter.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns the Miracast Transmitter's current authorization status.</summary>
    /// <returns>The Miracast Transmitter's current authorization status.</returns>
    public extern MiracastTransmitterAuthorizationStatus AuthorizationStatus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a collection of MiracastReceiverConnection objects that are associated with the current Miracast Transmitter.</summary>
    /// <returns>A collection of MiracastReceiverConnection objects that are associated with the current Miracast Transmitter.</returns>
    [MethodImpl]
    public extern IVectorView<MiracastReceiverConnection> GetConnections();

    /// <summary>Returns the Miracast Transmitter's Wi-Fi MAC address.</summary>
    /// <returns>The Miracast Transmitter's Wi-Fi MAC address.</returns>
    public extern string MacAddress { [MethodImpl] get; }

    /// <summary>Returns the time at which this Miracast Transmitter most recently connected.</summary>
    /// <returns>The time at which this Miracast Transmitter most recently connected.</returns>
    public extern DateTime LastConnectionTime { [MethodImpl] get; }
  }
}
