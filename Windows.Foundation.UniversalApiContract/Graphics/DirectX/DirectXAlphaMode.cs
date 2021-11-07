// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.DirectXAlphaMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX
{
  /// <summary>Identifies the alpha value, transparency behavior, of a surface. This is a Windows Runtime equivalent of the Desktop DXGI_ALPHA_MODE enumeration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum DirectXAlphaMode
  {
    /// <summary>Indicates that the transparency behavior is not specified.</summary>
    Unspecified,
    /// <summary>Indicates that the transparency behavior is premultiplied. Each color is first scaled by the alpha value. The alpha value itself is the same in both straight and premultiplied alpha. Typically, no color channel value is greater than the alpha channel value. If a color channel value in a premultiplied format is greater than the alpha channel, the standard source-over blending math results in an additive blend.</summary>
    Premultiplied,
    /// <summary>Indicates that the transparency behavior is not premultiplied. The alpha channel indicates the transparency of the color.</summary>
    Straight,
    /// <summary>Indicates to ignore the transparency behavior.</summary>
    Ignore,
  }
}
