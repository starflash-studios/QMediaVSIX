﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2400537008, 59580, 19582, 176, 9, 78, 65, 223, 19, 112, 114)]
  [ExclusiveTo(typeof (CompassReadingChangedEventArgs))]
  internal interface ICompassReadingChangedEventArgs
  {
    CompassReading Reading { get; }
  }
}