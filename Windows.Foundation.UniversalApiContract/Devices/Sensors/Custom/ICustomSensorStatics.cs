﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [ExclusiveTo(typeof (CustomSensor))]
  [Guid(2569032399, 62498, 19581, 131, 107, 231, 220, 116, 167, 18, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICustomSensorStatics
  {
    string GetDeviceSelector(Guid interfaceId);

    [RemoteAsync]
    IAsyncOperation<CustomSensor> FromIdAsync(string sensorId);
  }
}