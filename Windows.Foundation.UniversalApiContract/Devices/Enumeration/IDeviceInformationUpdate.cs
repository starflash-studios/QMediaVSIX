﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationUpdate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(2402374405, 55666, 17591, 163, 126, 158, 130, 44, 120, 33, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceInformationUpdate))]
  internal interface IDeviceInformationUpdate
  {
    string Id { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }
  }
}