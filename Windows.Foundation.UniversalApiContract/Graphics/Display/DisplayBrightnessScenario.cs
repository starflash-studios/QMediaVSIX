// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayBrightnessScenario
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes common brightness scenarios that have well-known brightness levels. These scenarios are used in the GetLevelForScenario() and SetBrightnessScenario() methods.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum DisplayBrightnessScenario
  {
    /// <summary>Sets the screen to the current screen brightness, essentially freezing the brightness.</summary>
    DefaultBrightness,
    /// <summary>Sets the screen to a battery friendly yet readable brightness level. This is currently set to 10% brightness.</summary>
    IdleBrightness,
    /// <summary>Sets the screen to the brightness level that it is easily readable by barcode readers. This is currently set to 100% brightness.</summary>
    BarcodeReadingBrightness,
    /// <summary>Sets the screen to 100% brightness.</summary>
    FullBrightness,
  }
}
