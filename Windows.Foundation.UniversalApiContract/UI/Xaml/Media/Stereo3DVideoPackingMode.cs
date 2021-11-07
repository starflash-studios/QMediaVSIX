// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Stereo3DVideoPackingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes the frame-packing mode for stereo 3-D video content.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Stereo3DVideoPackingMode
  {
    /// <summary>Regular 2-D video.</summary>
    None,
    /// <summary>Stereo 3-D content packing with components side-by-side.</summary>
    SideBySide,
    /// <summary>Stereo 3-D content packing with components top and bottom.</summary>
    TopBottom,
  }
}
