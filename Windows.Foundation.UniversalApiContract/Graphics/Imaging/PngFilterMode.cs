// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.PngFilterMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the filter used to optimize the image prior to image compression in PNG images.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PngFilterMode
  {
    /// <summary>The filter type will be chosen automatically.</summary>
    Automatic,
    /// <summary>The image is unmodified.</summary>
    None,
    /// <summary>The Sub type filter is applied.</summary>
    Sub,
    /// <summary>The Up filter type is applied.</summary>
    Up,
    /// <summary>The Average type filter is applied.</summary>
    Average,
    /// <summary>The Paeth type filter is applied.</summary>
    Paeth,
    /// <summary>The Adaptive type filter is applied.</summary>
    Adaptive,
  }
}
