// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.RfcommOutboundConnectionInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>Provides information for RFCOMM outbound connections. If an app wants the system to create outbound connections on its behalf, the app must create this object and attach it to the RfcommConnectionTrigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RfcommOutboundConnectionInformation : IRfcommOutboundConnectionInformation
  {
    /// <summary>Gets or sets the service UUID of the remote service to which the system will connect on behalf of the app.</summary>
    /// <returns>The service UUID of the remote service to which the system will connect on behalf of the app. This value must be set. When the system creates outgoing connections for the app, it will connect to any remote service that lists the specified UUID in its ServiceClassIDList.</returns>
    public extern RfcommServiceId RemoteServiceId { [MethodImpl] get; [MethodImpl] set; }
  }
}
