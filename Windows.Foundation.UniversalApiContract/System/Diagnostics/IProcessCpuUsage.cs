// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessCpuUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(196813938, 51391, 16954, 168, 16, 181, 89, 174, 67, 84, 226)]
  [ExclusiveTo(typeof (ProcessCpuUsage))]
  internal interface IProcessCpuUsage
  {
    ProcessCpuUsageReport GetReport();
  }
}
