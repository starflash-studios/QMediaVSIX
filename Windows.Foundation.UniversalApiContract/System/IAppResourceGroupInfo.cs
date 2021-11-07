// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppResourceGroupInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System.Diagnostics;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppResourceGroupInfo))]
  [Guid(3105093498, 59399, 18932, 132, 94, 123, 139, 220, 254, 142, 231)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppResourceGroupInfo
  {
    Guid InstanceId { get; }

    bool IsShared { get; }

    IVector<AppResourceGroupBackgroundTaskReport> GetBackgroundTaskReports();

    AppResourceGroupMemoryReport GetMemoryReport();

    IVector<ProcessDiagnosticInfo> GetProcessDiagnosticInfos();

    AppResourceGroupStateReport GetStateReport();
  }
}
