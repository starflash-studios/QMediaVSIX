// Decompiled with JetBrains decompiler
// Type: Windows.System.IProcessMemoryReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessMemoryReport))]
  [Guid(141755816, 39792, 18306, 135, 65, 58, 152, 43, 108, 229, 228)]
  internal interface IProcessMemoryReport
  {
    ulong PrivateWorkingSetUsage { get; }

    ulong TotalWorkingSetUsage { get; }
  }
}
