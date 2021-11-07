// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayBrightnessOverrideOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes the options that modify the brightness level of the screen during the override session. When __UseDimmedPolicyWhenBatteryIsLow__ is set, it reduces the specified override brightness level in order to conserve battery if the device</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum DisplayBrightnessOverrideOptions : uint
  {
    /// <summary>Screen display stays at the specified override brightness level when the device battery is low.</summary>
    None = 0,
    /// <summary>Screen display dims when the device battery is low and a brightness override session is running.</summary>
    UseDimmedPolicyWhenBatteryIsLow = 1,
  }
}
