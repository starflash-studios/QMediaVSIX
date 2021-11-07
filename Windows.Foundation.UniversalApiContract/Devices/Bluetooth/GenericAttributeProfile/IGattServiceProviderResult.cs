// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProviderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattServiceProviderResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1984337624, 50494, 17036, 138, 72, 103, 175, 224, 44, 58, 230)]
  internal interface IGattServiceProviderResult
  {
    BluetoothError Error { get; }

    GattServiceProvider ServiceProvider { get; }
  }
}
