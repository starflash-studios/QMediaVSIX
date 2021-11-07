// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Sms;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandDeviceInformation))]
  [Guid(3872424296, 58241, 19566, 155, 232, 254, 21, 105, 105, 164, 70)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandDeviceInformation
  {
    NetworkDeviceStatus NetworkDeviceStatus { get; }

    string Manufacturer { get; }

    string Model { get; }

    string FirmwareInformation { get; }

    CellularClass CellularClass { get; }

    DataClasses DataClasses { get; }

    string CustomDataClass { get; }

    string MobileEquipmentId { get; }

    IVectorView<string> TelephoneNumbers { get; }

    string SubscriberId { get; }

    string SimIccId { get; }

    MobileBroadbandDeviceType DeviceType { get; }

    string DeviceId { get; }

    MobileBroadbandRadioState CurrentRadioState { get; }
  }
}
