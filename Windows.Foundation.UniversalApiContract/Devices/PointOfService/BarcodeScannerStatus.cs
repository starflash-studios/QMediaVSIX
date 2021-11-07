// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScannerStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the barcode scanner status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BarcodeScannerStatus
  {
    /// <summary>The device is online. This is valid if UnifiedPosPowerReportingType is Standard or Advanced.</summary>
    Online,
    /// <summary>The device power is off or detached from the terminal. This is valid if UnifiedPosPowerReportingType is Advanced.</summary>
    Off,
    /// <summary>The device power is on, but it is not ready or unable to respond to requests. This is valid if UnifiedPosPowerReportingType is Advanced.</summary>
    Offline,
    /// <summary>The device power is off or the device is offline. This is valid if UnifiedPosPowerReportingType is Standard.</summary>
    OffOrOffline,
    /// <summary>Vendor specific status information.</summary>
    Extended,
  }
}
