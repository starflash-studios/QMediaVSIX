// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>An object which provides information about the current status of the MiracastReceiver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverStatus : IMiracastReceiverStatus
  {
    /// <summary>Returns a value that describes the status of the Miracast Receiver as it pertains to its ability to listen for incoming conections.</summary>
    /// <returns>Describes the status of the Miracast Receiver as it pertains to its ability to listen for incoming conections.</returns>
    public extern MiracastReceiverListeningStatus ListeningStatus { [MethodImpl] get; }

    /// <summary>Returns status information about the Miracast Receiver's Wi-Fi functionality.</summary>
    /// <returns>Status information about the Miracast Receiver's Wi-Fi functionality.</returns>
    public extern MiracastReceiverWiFiStatus WiFiStatus { [MethodImpl] get; }

    /// <summary>Specifies if it is possible to let a new Miracast connection take over an in-progress Miracast connection.</summary>
    /// <returns>True if it is possible to let a new Miracast connection take over an in-progress Miracast connection.</returns>
    public extern bool IsConnectionTakeoverSupported { [MethodImpl] get; }

    /// <summary>Specifies the maximum number of simultaneous connections that the Miracast Receiver can handle.</summary>
    /// <returns>The maximum number of simultaneous connections that the Miracast Receiver can handle.</returns>
    public extern int MaxSimultaneousConnections { [MethodImpl] get; }

    /// <summary>Returns the collection of Miracast Transmitters that are currently known to the MiracastReceiver.</summary>
    /// <returns>The collection of Miracast Transmitters that are currently known to the Miracast Receiver.</returns>
    public extern IVectorView<MiracastTransmitter> KnownTransmitters { [MethodImpl] get; }
  }
}
