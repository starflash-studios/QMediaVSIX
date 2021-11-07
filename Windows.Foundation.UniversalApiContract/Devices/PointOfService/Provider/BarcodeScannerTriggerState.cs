// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerTriggerState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Defines the constants that indicate the barcode trigger state.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum BarcodeScannerTriggerState
  {
    /// <summary>The barcode scanner trigger or button is released during a scanning operation.</summary>
    Released,
    /// <summary>The barcode scanner trigger or button is pressed during a scanning operation.</summary>
    Pressed,
  }
}
