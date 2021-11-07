// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.UnifiedPosHealthCheckLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicates the type of health check that can be performed on the devices.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UnifiedPosHealthCheckLevel
  {
    /// <summary>Perform an unspecified test.</summary>
    UnknownHealthCheckLevel,
    /// <summary>Perform internal tests to that do not physically change the device.</summary>
    POSInternal,
    /// <summary>Perform a more thorough test that may change the device.</summary>
    External,
    /// <summary>Perform a interactive test of the device. The supporting service object will typically display a modal dialog box to present test options and results.</summary>
    Interactive,
  }
}
