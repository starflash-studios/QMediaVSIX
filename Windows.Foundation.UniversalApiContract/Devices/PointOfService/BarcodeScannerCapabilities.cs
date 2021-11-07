// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScannerCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the barcode scanner capabilities.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BarcodeScannerCapabilities : 
    IBarcodeScannerCapabilities,
    IBarcodeScannerCapabilities1,
    IBarcodeScannerCapabilities2
  {
    /// <summary>Gets the power reporting type for the barcode scanner.</summary>
    /// <returns>Power reporting type.</returns>
    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    /// <summary>Indicates whether the barcode scanner supports reporting of usage statistics.</summary>
    /// <returns>True if the barcode scanner supports statistics reporting; otherwise, false.</returns>
    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the barcode scanner supports updating or resetting of usage statistics.</summary>
    /// <returns>True if the barcode scanner supports updating of usage statistics; otherwise, false.</returns>
    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the barcode scanner supports image preview.</summary>
    /// <returns>True if the barcode scanner supports image preview; otherwise, false.</returns>
    public extern bool IsImagePreviewSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the barcode scanner supports the software trigger functionality.</summary>
    /// <returns>True if the software trigger is supported; otherwise, false.</returns>
    public extern bool IsSoftwareTriggerSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the barcode scanner supports displaying a live video preview from an attached camera.</summary>
    /// <returns>True if the barcode scanner supports displaying a live video preview; otherwise, false.</returns>
    public extern bool IsVideoPreviewSupported { [MethodImpl] get; }
  }
}
