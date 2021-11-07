// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattSessionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattSession))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(778418524, 21407, 19895, 130, 168, 115, 189, 187, 247, 62, 191)]
  internal interface IGattSessionStatics
  {
    [RemoteAsync]
    IAsyncOperation<GattSession> FromDeviceIdAsync(
      BluetoothDeviceId deviceId);
  }
}
