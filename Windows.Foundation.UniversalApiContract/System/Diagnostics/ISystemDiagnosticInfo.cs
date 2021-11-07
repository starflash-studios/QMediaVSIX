// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemDiagnosticInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (SystemDiagnosticInfo))]
  [Guid(2727411205, 57331, 16511, 154, 27, 11, 43, 49, 124, 168, 0)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISystemDiagnosticInfo
  {
    SystemMemoryUsage MemoryUsage { get; }

    SystemCpuUsage CpuUsage { get; }
  }
}
