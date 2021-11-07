// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.RfcommInboundConnectionInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>Provides information about incoming RFCOMM connections. If an app wants the system to listen for incoming connections on behalf of an RfcommConnectionTrigger, the app must create this object and attach it to the RfcommConnectionTrigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RfcommInboundConnectionInformation : IRfcommInboundConnectionInformation
  {
    /// <summary>Gets or sets the Bluetooth SDP record that the system will advertise on behalf of the app.</summary>
    /// <returns>The Bluetooth SDP record that the system will advertise on behalf of the app.</returns>
    public extern IBuffer SdpRecord { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the service UUID that will be advertised in the SDP record.</summary>
    /// <returns>The service UUID that will be advertised in the SDP record.</returns>
    public extern RfcommServiceId LocalServiceId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the service capabilities that will be advertised.</summary>
    /// <returns>One of the BluetoothServiceCapabilities enumeration values that specifies the service capabilities to be advertised.</returns>
    public extern BluetoothServiceCapabilities ServiceCapabilities { [MethodImpl] get; [MethodImpl] set; }
  }
}
