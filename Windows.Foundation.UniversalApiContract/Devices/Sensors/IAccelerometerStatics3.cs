﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2648840399, 17757, 19699, 130, 0, 112, 225, 65, 3, 64, 248)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (Accelerometer))]
  internal interface IAccelerometerStatics3
  {
    [RemoteAsync]
    IAsyncOperation<Accelerometer> FromIdAsync(string deviceId);

    string GetDeviceSelector(AccelerometerReadingType readingType);
  }
}