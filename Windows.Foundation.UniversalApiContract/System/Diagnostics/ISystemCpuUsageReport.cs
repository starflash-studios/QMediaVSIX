﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemCpuUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (SystemCpuUsageReport))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(740741298, 38019, 20322, 171, 87, 130, 178, 157, 151, 25, 184)]
  internal interface ISystemCpuUsageReport
  {
    TimeSpan KernelTime { get; }

    TimeSpan UserTime { get; }

    TimeSpan IdleTime { get; }
  }
}