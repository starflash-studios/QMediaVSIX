// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessMemoryUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Guid(4111147675, 33404, 17079, 176, 124, 14, 50, 98, 126, 107, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessMemoryUsage))]
  internal interface IProcessMemoryUsage
  {
    ProcessMemoryUsageReport GetReport();
  }
}
