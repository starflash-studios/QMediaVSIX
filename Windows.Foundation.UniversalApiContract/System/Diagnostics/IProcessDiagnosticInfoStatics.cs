﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiagnosticInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessDiagnosticInfo))]
  [Guid(792834656, 46239, 17036, 170, 14, 132, 116, 79, 73, 202, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProcessDiagnosticInfoStatics
  {
    IVectorView<ProcessDiagnosticInfo> GetForProcesses();

    ProcessDiagnosticInfo GetForCurrentProcess();
  }
}