// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessCpuUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessCpuUsageReport))]
  [Guid(2322439340, 14727, 20015, 161, 25, 107, 95, 162, 20, 241, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProcessCpuUsageReport
  {
    TimeSpan KernelTime { get; }

    TimeSpan UserTime { get; }
  }
}
