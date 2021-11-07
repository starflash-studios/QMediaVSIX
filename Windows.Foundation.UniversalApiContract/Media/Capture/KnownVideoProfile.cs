// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.KnownVideoProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Specifies the names of video recording profiles that are known by the system.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KnownVideoProfile
  {
    /// <summary>The profile provides hints to the driver to optimize for high-quality video, prioritizing higher resolution and frame rates over power consumption and latency.</summary>
    VideoRecording,
    /// <summary>The profile provides hints to the driver to optimize for high-quality photo capture.</summary>
    HighQualityPhoto,
    /// <summary>The profile provides hints to the driver to allow for photo capture during video capture with balanced quality between both.</summary>
    BalancedVideoAndPhoto,
    /// <summary>The profile provides hints to the driver to optimize for VoIP scenarios, prioritizing lower power consumption, lower latency, and concurrency (for example, using the front and back cameras of a device simultaneously) while deprioritizing higher resolution.</summary>
    VideoConferencing,
    /// <summary>The profile provides hints to the driver to optimize for capturing photo sequences.</summary>
    PhotoSequence,
    /// <summary>The profile provides hints to the driver to optimize for high frame rate video capture.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] HighFrameRate,
    /// <summary>The profile provides hints to the driver to optimize for capturing variable photo sequences.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] VariablePhotoSequence,
    /// <summary>The profile provides hints to the driver to optimize for High Dynamic Range (HDR) with Wide Color Gamut (WCG) video.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] HdrWithWcgVideo,
    /// <summary>The profile provides hints to the driver to optimize for High Dynamic Range (HDR) with Wide Color Gamut (WCG) photo.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] HdrWithWcgPhoto,
    /// <summary>The profile provides hints to the driver to optimize for High Dynamic Range (HDR) video.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] VideoHdr8,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] CompressedCamera,
  }
}
