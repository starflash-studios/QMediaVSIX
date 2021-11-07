// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverListeningStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Describes the status of the Miracast Receiver as it pertains to its ability to listen for incoming conections.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastReceiverListeningStatus
  {
    /// <summary>The Miracast Receiver is not currently listening for incoming connections.</summary>
    NotListening,
    /// <summary>The Miracast Receiver is listening for incoming connections.</summary>
    Listening,
    /// <summary>The Miracast Receiver has received an incoming connection and is waiting for the app to accept or reject the connection.</summary>
    ConnectionPending,
    /// <summary>At least one Miracast Transmitter is currently connected.</summary>
    Connected,
    /// <summary>The Miracast Receiver has been disabled by administrative policy.</summary>
    DisabledByPolicy,
    /// <summary>The Miracast Receiver is temporarily disabled while other network activity is in progress.</summary>
    TemporarilyDisabled,
  }
}
