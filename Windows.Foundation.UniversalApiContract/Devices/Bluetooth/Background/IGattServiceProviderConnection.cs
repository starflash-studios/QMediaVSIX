// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattServiceProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2141305273, 12051, 16565, 149, 130, 142, 183, 142, 152, 239, 19)]
  [ExclusiveTo(typeof (GattServiceProviderConnection))]
  internal interface IGattServiceProviderConnection
  {
    string TriggerId { get; }

    GattLocalService Service { get; }

    void Start();
  }
}
