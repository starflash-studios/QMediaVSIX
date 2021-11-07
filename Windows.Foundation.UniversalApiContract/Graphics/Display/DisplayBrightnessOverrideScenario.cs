﻿// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayBrightnessOverrideScenario
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Represents the brightness scenarios that a BrightnessOverrideSettings object can request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum DisplayBrightnessOverrideScenario
  {
    /// <summary>Indicates that a brightness level to be used when the app is idle.</summary>
    IdleBrightness,
    /// <summary>Indicates that a brightness level which is barcode reader friendly is wanted.</summary>
    BarcodeReadingBrightness,
    /// <summary>Indicates that a brightness level of 100% is wanted.</summary>
    FullBrightness,
  }
}