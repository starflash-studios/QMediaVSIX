﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ISlipPrinterCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (SlipPrinterCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2578539417, 18572, 16727, 138, 194, 159, 87, 247, 8, 211, 219)]
  internal interface ISlipPrinterCapabilities
  {
    bool IsFullLengthSupported { get; }

    bool IsBothSidesPrintingSupported { get; }
  }
}