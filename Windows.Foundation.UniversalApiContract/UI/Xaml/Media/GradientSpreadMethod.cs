// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GradientSpreadMethod
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Specifies how to draw the gradient outside a gradient brush's gradient vector or space.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum GradientSpreadMethod
  {
    /// <summary>The color values at the ends of the gradient vector fill the remaining space.</summary>
    Pad,
    /// <summary>The gradient is repeated in the reverse direction until the space is filled.</summary>
    Reflect,
    /// <summary>The gradient is repeated in the original direction until the space is filled.</summary>
    Repeat,
  }
}
