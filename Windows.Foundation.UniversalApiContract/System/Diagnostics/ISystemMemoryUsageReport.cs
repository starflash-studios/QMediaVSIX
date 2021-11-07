// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemMemoryUsageReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SystemMemoryUsageReport))]
  [Guid(946224263, 10911, 16442, 189, 25, 44, 243, 232, 22, 149, 0)]
  internal interface ISystemMemoryUsageReport
  {
    ulong TotalPhysicalSizeInBytes { get; }

    ulong AvailableSizeInBytes { get; }

    ulong CommittedSizeInBytes { get; }
  }
}
