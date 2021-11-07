// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceUuidsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattServiceUuids))]
  [Guid(1841655896, 39610, 17431, 184, 242, 220, 224, 22, 211, 78, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGattServiceUuidsStatics
  {
    Guid Battery { get; }

    Guid BloodPressure { get; }

    Guid CyclingSpeedAndCadence { get; }

    Guid GenericAccess { get; }

    Guid GenericAttribute { get; }

    Guid Glucose { get; }

    Guid HealthThermometer { get; }

    Guid HeartRate { get; }

    Guid RunningSpeedAndCadence { get; }
  }
}
