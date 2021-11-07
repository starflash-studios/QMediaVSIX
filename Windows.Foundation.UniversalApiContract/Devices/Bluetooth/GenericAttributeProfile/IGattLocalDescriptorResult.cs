// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalDescriptorResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattLocalDescriptorResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(928485822, 12831, 17254, 191, 193, 59, 198, 184, 44, 121, 248)]
  internal interface IGattLocalDescriptorResult
  {
    GattLocalDescriptor Descriptor { get; }

    BluetoothError Error { get; }
  }
}
