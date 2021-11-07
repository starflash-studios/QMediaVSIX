// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattServiceProviderConnectionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Guid(1028693835, 2830, 17510, 184, 205, 110, 189, 218, 31, 161, 125)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattServiceProviderConnection))]
  internal interface IGattServiceProviderConnectionStatics
  {
    IMapView<string, GattServiceProviderConnection> AllServices { get; }
  }
}
