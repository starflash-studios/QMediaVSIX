﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IRegionOfInterest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (RegionOfInterest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(436087441, 29610, 19793, 138, 157, 86, 204, 247, 219, 127, 84)]
  internal interface IRegionOfInterest2
  {
    RegionOfInterestType Type { get; set; }

    bool BoundsNormalized { get; set; }

    uint Weight { get; set; }
  }
}