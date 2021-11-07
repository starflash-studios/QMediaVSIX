// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattSession))]
  [Guid(3527102787, 57422, 19492, 153, 156, 156, 37, 111, 152, 86, 177)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattSession
  {
    BluetoothDeviceId DeviceId { get; }

    bool CanMaintainConnection { get; }

    bool MaintainConnection { set; get; }

    ushort MaxPduSize { get; }

    GattSessionStatus SessionStatus { get; }

    event TypedEventHandler<GattSession, object> MaxPduSizeChanged;

    event TypedEventHandler<GattSession, GattSessionStatusChangedEventArgs> SessionStatusChanged;
  }
}
