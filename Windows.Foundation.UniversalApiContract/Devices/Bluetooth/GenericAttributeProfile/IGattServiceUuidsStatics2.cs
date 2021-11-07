// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceUuidsStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattServiceUuids))]
  [Guid(3534656757, 15637, 20345, 156, 12, 234, 175, 166, 117, 21, 92)]
  internal interface IGattServiceUuidsStatics2
  {
    Guid AlertNotification { get; }

    Guid CurrentTime { get; }

    Guid CyclingPower { get; }

    Guid DeviceInformation { get; }

    Guid HumanInterfaceDevice { get; }

    Guid ImmediateAlert { get; }

    Guid LinkLoss { get; }

    Guid LocationAndNavigation { get; }

    Guid NextDstChange { get; }

    Guid PhoneAlertStatus { get; }

    Guid ReferenceTimeUpdate { get; }

    Guid ScanParameters { get; }

    Guid TxPower { get; }
  }
}
