// Decompiled with JetBrains decompiler
// Type: Windows.UI.Color
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI
{
  /// <summary>Describes a color in terms of alpha, red, green, and blue channels.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct Color
  {
    /// <summary>Gets or sets the **sRGB** alpha channel value of the color.</summary>
    public byte A;
    /// <summary>Gets or sets the **sRGB** red channel value of the color.</summary>
    public byte R;
    /// <summary>Gets or sets the **sRGB** green channel value of the color.</summary>
    public byte G;
    /// <summary>Gets or sets the **sRGB** blue channel value of the color.</summary>
    public byte B;
  }
}
