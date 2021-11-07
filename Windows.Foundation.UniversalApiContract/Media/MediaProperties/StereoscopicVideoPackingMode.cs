// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.StereoscopicVideoPackingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Specifies the stereoscopic video packing mode of a video stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum StereoscopicVideoPackingMode
  {
    /// <summary>The video stream does not use stereoscopic video packing.</summary>
    None,
    /// <summary>The video stream packs stereoscopic video frames side by side.</summary>
    SideBySide,
    /// <summary>The video stream packs stereoscopic video frames using the top and bottom of the frame.</summary>
    TopBottom,
  }
}
