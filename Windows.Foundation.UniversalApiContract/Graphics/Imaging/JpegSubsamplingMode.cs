// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.JpegSubsamplingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies which chroma subsampling mode will be used for image compression in JPEG images.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum JpegSubsamplingMode
  {
    /// <summary>The default mode will be used.</summary>
    Default,
    /// <summary>4:2:0 (2x2) chroma subsampling will be used.</summary>
    Y4Cb2Cr0,
    /// <summary>4:2:2 (2x1) chroma subsampling will be used.</summary>
    Y4Cb2Cr2,
    /// <summary>4:4:4 (1x1) chroma subsampling will be used.</summary>
    Y4Cb4Cr4,
  }
}
