﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1807579327, 56481, 19974, 153, 235, 90, 246, 165, 174, 193, 8)]
  [ExclusiveTo(typeof (CashDrawerStatus))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICashDrawerStatus
  {
    CashDrawerStatusKind StatusKind { get; }

    uint ExtendedStatus { get; }
  }
}