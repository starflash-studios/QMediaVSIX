// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSourceKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Specifies the kind of data produced by a MediaFrameSource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaFrameSourceKind
  {
    /// <summary>The media frame source produces custom data.</summary>
    Custom,
    /// <summary>The media frame source produces color data.</summary>
    Color,
    /// <summary>The media frame source produces infrared data.</summary>
    Infrared,
    /// <summary>The media frame source produces depth data.</summary>
    Depth,
    /// <summary>The media frame source produces audio data.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] Audio,
    /// <summary>The media frame source produces image data.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] Image,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] Metadata,
  }
}
