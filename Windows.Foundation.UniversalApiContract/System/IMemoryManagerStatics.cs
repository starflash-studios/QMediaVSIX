// Decompiled with JetBrains decompiler
// Type: Windows.System.IMemoryManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (MemoryManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1550591900, 55242, 18297, 145, 136, 64, 87, 33, 156, 230, 76)]
  internal interface IMemoryManagerStatics
  {
    ulong AppMemoryUsage { get; }

    ulong AppMemoryUsageLimit { get; }

    AppMemoryUsageLevel AppMemoryUsageLevel { get; }

    event EventHandler<object> AppMemoryUsageIncreased;

    event EventHandler<object> AppMemoryUsageDecreased;

    event EventHandler<AppMemoryUsageLimitChangingEventArgs> AppMemoryUsageLimitChanging;
  }
}
