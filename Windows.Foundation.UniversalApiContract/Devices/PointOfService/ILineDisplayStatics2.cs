﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1611415324, 30635, 18792, 167, 222, 192, 47, 241, 105, 242, 204)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (LineDisplay))]
  internal interface ILineDisplayStatics2
  {
    LineDisplayStatisticsCategorySelector StatisticsCategorySelector { get; }
  }
}