// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalDescriptorParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattLocalDescriptorParameters))]
  [Guid(1608441450, 62401, 19302, 140, 75, 227, 210, 41, 59, 64, 233)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattLocalDescriptorParameters
  {
    IBuffer StaticValue { set; get; }

    GattProtectionLevel ReadProtectionLevel { set; get; }

    GattProtectionLevel WriteProtectionLevel { set; get; }
  }
}
