﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayStatusUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplayStatusUpdatedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3721755674, 34555, 20154, 147, 209, 111, 94, 218, 82, 183, 82)]
  internal interface ILineDisplayStatusUpdatedEventArgs
  {
    LineDisplayPowerStatus Status { get; }
  }
}