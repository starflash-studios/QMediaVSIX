// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.RfcommConnectionTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>Provides information about the Bluetooth device that caused this trigger to fire.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RfcommConnectionTriggerDetails : IRfcommConnectionTriggerDetails
  {
    /// <summary>Gets a reference to the underlying StreamSocket of this connection.</summary>
    /// <returns>A reference to the underlying StreamSocket of this connection.</returns>
    public extern StreamSocket Socket { [MethodImpl] get; }

    /// <summary>Gets whether this is an incoming connection.</summary>
    /// <returns>True if the trigger was fired for an incoming connection; otherwise, false.</returns>
    public extern bool Incoming { [MethodImpl] get; }

    /// <summary>Gets the BluetoothDevice object that represents the remote device.</summary>
    /// <returns>The BluetoothDevice object that represents the remote device.</returns>
    public extern BluetoothDevice RemoteDevice { [MethodImpl] get; }
  }
}
