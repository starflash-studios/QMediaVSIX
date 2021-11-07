// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SliderSnapsTo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify how a Slider or related range control class conforms the indicator position to its steps or tick marks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum SliderSnapsTo
  {
    /// <summary>Conform the indicator to the step values.</summary>
    StepValues,
    /// <summary>Conform the indicator to the tick marks.</summary>
    Ticks,
  }
}
