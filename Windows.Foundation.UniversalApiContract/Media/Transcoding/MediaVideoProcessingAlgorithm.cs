// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.MediaVideoProcessingAlgorithm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Transcoding
{
  /// <summary>Defines the available algorithms used by the Transcode Video Processor (XVP).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaVideoProcessingAlgorithm
  {
    /// <summary>Default video processing algorithm. This algorithm prefers performance, speed, and space over quality. This algorithm will makes use of hardware.</summary>
    Default,
    /// <summary>Prefers quality over performance. This mode always runs in software and insures that hardware implementations, which may differ from the XVP are not used.</summary>
    MrfCrf444,
  }
}
