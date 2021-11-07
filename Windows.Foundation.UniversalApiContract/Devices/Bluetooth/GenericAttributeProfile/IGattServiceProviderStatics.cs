// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProviderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattServiceProvider))]
  [Guid(830029923, 21078, 16468, 164, 244, 123, 190, 119, 85, 165, 126)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattServiceProviderStatics
  {
    [RemoteAsync]
    [Overload("CreateAsync")]
    IAsyncOperation<GattServiceProviderResult> CreateAsync(
      Guid serviceUuid);
  }
}
