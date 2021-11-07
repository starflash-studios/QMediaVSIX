// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayStatisticsCategorySelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a standard statistics category selector.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineDisplayStatisticsCategorySelector : ILineDisplayStatisticsCategorySelector
  {
    /// <summary>Retrieves all device statistics when provided to ClaimedLineDisplay.GetStatisticsAsync(IEnumerable&lt;String&gt;).</summary>
    /// <returns>The UnifiedPOS value for retrieving all statistics from a device.</returns>
    public extern string AllStatistics { [MethodImpl] get; }

    /// <summary>Retrieves UnifiedPOS statistics when provided to ClaimedLineDisplay.GetStatisticsAsync(IEnumerable&lt;String&gt;).</summary>
    /// <returns>The UnifiedPOS value for retrieving UnifiedPOS statistics from a device.</returns>
    public extern string UnifiedPosStatistics { [MethodImpl] get; }

    /// <summary>Retrieves manufacturer-defined statistics when provided to [ClaimedLineDisplay.GetStatisticsAsync(IEnumerable&lt;String&gt;)](claimedlinedisplay_getstatisticsasync_980600774.md.</summary>
    /// <returns>The UnifiedPOS value for retrieving manufacturer-defined statistics from a device.</returns>
    public extern string ManufacturerStatistics { [MethodImpl] get; }
  }
}
