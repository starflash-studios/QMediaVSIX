// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ColorPickerHsvChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines contstants that specify which Hue-Saturation-Value-Alpha component a slider in a ColorPicker controls.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public enum ColorPickerHsvChannel
  {
    /// <summary>The slider controls the Hue channel.</summary>
    Hue,
    /// <summary>The slider controls the Saturation channel.</summary>
    Saturation,
    /// <summary>The slider controls the Value channel.</summary>
    Value,
    /// <summary>The slider controls the Alpha channel.</summary>
    Alpha,
  }
}
