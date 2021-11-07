// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.UnifiedPosPowerReportingType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicates power reporting capabilities of the Point of Service (POS) device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UnifiedPosPowerReportingType
  {
    /// <summary>Cannot determine the state of the device, therefore no power reporting is possible.</summary>
    UnknownPowerReportingType,
    /// <summary>Can determine and report the two power states (online and off/offline) of the device.</summary>
    Standard,
    /// <summary>Can determine and report the three power states (off, offline, and online) of the device.</summary>
    Advanced,
  }
}
