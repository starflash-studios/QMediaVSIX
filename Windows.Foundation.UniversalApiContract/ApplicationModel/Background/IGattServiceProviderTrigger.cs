﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattServiceProviderTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (GattServiceProviderTrigger))]
  [Guid(3720782825, 5463, 19416, 133, 66, 70, 138, 160, 198, 150, 246)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattServiceProviderTrigger
  {
    string TriggerId { get; }

    GattLocalService Service { get; }

    GattServiceProviderAdvertisingParameters AdvertisingParameters { set; get; }
  }
}