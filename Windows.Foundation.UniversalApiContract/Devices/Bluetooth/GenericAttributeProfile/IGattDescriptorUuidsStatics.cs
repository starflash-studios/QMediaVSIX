// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDescriptorUuidsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2801296078, 40188, 17137, 145, 133, 255, 55, 183, 81, 129, 211)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattDescriptorUuids))]
  internal interface IGattDescriptorUuidsStatics
  {
    Guid CharacteristicAggregateFormat { get; }

    Guid CharacteristicExtendedProperties { get; }

    Guid CharacteristicPresentationFormat { get; }

    Guid CharacteristicUserDescription { get; }

    Guid ClientCharacteristicConfiguration { get; }

    Guid ServerCharacteristicConfiguration { get; }
  }
}
