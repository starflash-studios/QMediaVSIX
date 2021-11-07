// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiskUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Guid(1075193853, 21341, 19487, 129, 184, 218, 84, 225, 190, 99, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessDiskUsageReport))]
  internal interface IProcessDiskUsageReport
  {
    long ReadOperationCount { get; }

    long WriteOperationCount { get; }

    long OtherOperationCount { get; }

    long BytesReadCount { get; }

    long BytesWrittenCount { get; }

    long OtherBytesCount { get; }
  }
}
