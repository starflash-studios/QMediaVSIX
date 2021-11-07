// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IDataPlanStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataPlanStatus))]
  [Guid(2541390732, 14469, 16627, 136, 81, 66, 205, 43, 213, 104, 187)]
  internal interface IDataPlanStatus
  {
    DataPlanUsage DataPlanUsage { get; }

    IReference<uint> DataLimitInMegabytes { get; }

    IReference<ulong> InboundBitsPerSecond { get; }

    IReference<ulong> OutboundBitsPerSecond { get; }

    IReference<DateTime> NextBillingCycle { get; }

    IReference<uint> MaxTransferSizeInMegabytes { get; }
  }
}
