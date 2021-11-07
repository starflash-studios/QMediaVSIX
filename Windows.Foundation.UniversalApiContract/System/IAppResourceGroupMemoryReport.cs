// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppResourceGroupMemoryReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (AppResourceGroupMemoryReport))]
  [Guid(747374257, 32177, 19537, 162, 37, 127, 174, 45, 73, 228, 49)]
  internal interface IAppResourceGroupMemoryReport
  {
    ulong CommitUsageLimit { get; }

    AppMemoryUsageLevel CommitUsageLevel { get; }

    ulong PrivateCommitUsage { get; }

    ulong TotalCommitUsage { get; }
  }
}
