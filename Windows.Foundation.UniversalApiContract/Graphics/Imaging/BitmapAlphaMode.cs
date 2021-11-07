// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapAlphaMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the alpha mode of pixel data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BitmapAlphaMode
  {
    /// <summary>The alpha value has been premultiplied. Each color is first scaled by the alpha value.</summary>
    Premultiplied,
    /// <summary>The alpha value has not been premultiplied. The alpha channel indicates the transparency of the color.</summary>
    Straight,
    /// <summary>The alpha value is ignored.</summary>
    Ignore,
  }
}
