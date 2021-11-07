// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the cash drawer capabilities.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CashDrawerCapabilities : ICashDrawerCapabilities
  {
    /// <summary>Whether the cash drawer has standard or advanced power reporting.</summary>
    /// <returns>Defines the constants that indicates power reporting capabilities of the cash drawer.</returns>
    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    /// <summary>Whether statistics reporting is supported by the cash drawer.</summary>
    /// <returns>True if statistics reporting is supported by the cash drawer; otherwise, false.</returns>
    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    /// <summary>Whether statistics updating is supported by the cash drawer.</summary>
    /// <returns>True if statistics updating is supported by the cash drawer; otherwise, false.</returns>
    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    /// <summary>Whether status reporting is supported by the cash drawer.</summary>
    /// <returns>True if status reporting is supported, otherwise false.</returns>
    public extern bool IsStatusReportingSupported { [MethodImpl] get; }

    /// <summary>Whether the status from multiple drawers is supported.</summary>
    /// <returns>True if multiple drawer detection is supported, otherwise false.</returns>
    public extern bool IsStatusMultiDrawerDetectSupported { [MethodImpl] get; }

    /// <summary>Indicated whether cash drawer open sensor is available.</summary>
    /// <returns>True if the sensor is available, otherwise false.</returns>
    public extern bool IsDrawerOpenSensorAvailable { [MethodImpl] get; }
  }
}
