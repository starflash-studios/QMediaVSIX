// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverGameControllerDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [Guid(762409448, 48852, 20760, 160, 88, 226, 71, 126, 181, 136, 141)]
  [ExclusiveTo(typeof (MiracastReceiverGameControllerDevice))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverGameControllerDevice
  {
    bool TransmitInput { get; set; }

    bool IsRequestedByTransmitter { get; }

    bool IsTransmittingInput { get; }

    MiracastReceiverGameControllerDeviceUsageMode Mode { get; set; }

    event TypedEventHandler<MiracastReceiverGameControllerDevice, object> Changed;
  }
}
