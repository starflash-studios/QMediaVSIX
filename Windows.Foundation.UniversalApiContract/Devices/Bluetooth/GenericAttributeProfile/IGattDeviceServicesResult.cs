﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceServicesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(387830766, 365, 16797, 131, 138, 87, 108, 244, 117, 163, 216)]
  [ExclusiveTo(typeof (GattDeviceServicesResult))]
  internal interface IGattDeviceServicesResult
  {
    GattCommunicationStatus Status { get; }

    IReference<byte> ProtocolError { get; }

    IVectorView<GattDeviceService> Services { get; }
  }
}