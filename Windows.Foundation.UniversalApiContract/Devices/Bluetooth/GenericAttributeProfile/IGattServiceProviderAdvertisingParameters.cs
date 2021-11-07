// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProviderAdvertisingParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3805163947, 25365, 19490, 155, 215, 120, 29, 188, 61, 141, 130)]
  [ExclusiveTo(typeof (GattServiceProviderAdvertisingParameters))]
  internal interface IGattServiceProviderAdvertisingParameters
  {
    bool IsConnectable { set; get; }

    bool IsDiscoverable { set; get; }
  }
}
