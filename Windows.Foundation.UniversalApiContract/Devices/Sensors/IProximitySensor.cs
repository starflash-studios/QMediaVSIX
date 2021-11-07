// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (ProximitySensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1421899448, 60667, 18756, 185, 40, 116, 252, 80, 77, 71, 238)]
  internal interface IProximitySensor
  {
    string DeviceId { get; }

    IReference<uint> MaxDistanceInMillimeters { get; }

    IReference<uint> MinDistanceInMillimeters { get; }

    ProximitySensorReading GetCurrentReading();

    event TypedEventHandler<ProximitySensor, ProximitySensorReadingChangedEventArgs> ReadingChanged;

    ProximitySensorDisplayOnOffController CreateDisplayOnOffController();
  }
}
