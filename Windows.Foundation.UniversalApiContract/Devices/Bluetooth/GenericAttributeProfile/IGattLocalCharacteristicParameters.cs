// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalCharacteristicParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4210507188, 19711, 17607, 132, 69, 4, 14, 110, 173, 0, 99)]
  [ExclusiveTo(typeof (GattLocalCharacteristicParameters))]
  internal interface IGattLocalCharacteristicParameters
  {
    IBuffer StaticValue { set; get; }

    GattCharacteristicProperties CharacteristicProperties { set; get; }

    GattProtectionLevel ReadProtectionLevel { set; get; }

    GattProtectionLevel WriteProtectionLevel { set; get; }

    string UserDescription { set; get; }

    IVector<GattPresentationFormat> PresentationFormats { get; }
  }
}
