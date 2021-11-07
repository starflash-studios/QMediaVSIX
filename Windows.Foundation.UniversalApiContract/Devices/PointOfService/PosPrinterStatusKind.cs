// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterStatusKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the power state for a point-of-service printer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterStatusKind
  {
    /// <summary>The printer is online.</summary>
    Online,
    /// <summary>The printer is turned off or disconnected from the terminal.</summary>
    Off,
    /// <summary>The printer is turned on, but it is not ready or not able to respond to requests.</summary>
    Offline,
    /// <summary>The printer is either turned off, or turned on but not ready or not able to respond to requests.</summary>
    OffOrOffline,
    /// <summary>The original equipment manufacturer (OEM) reports extended information about the power state of the printer in the PosPrinterStatus.ExtendedStatus property.</summary>
    Extended,
  }
}
