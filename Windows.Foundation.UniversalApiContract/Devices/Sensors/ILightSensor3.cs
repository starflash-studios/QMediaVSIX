﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensor3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (LightSensor))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(1215746303, 40780, 24434, 173, 189, 163, 71, 27, 6, 60, 0)]
  internal interface ILightSensor3
  {
    LightSensorDataThreshold ReportThreshold { get; }
  }
}