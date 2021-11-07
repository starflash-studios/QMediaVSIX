// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaStreamType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Specifies a type of stream on a media capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaStreamType
  {
    /// <summary>A video preview stream.</summary>
    VideoPreview,
    /// <summary>A video recording stream.</summary>
    VideoRecord,
    /// <summary>An audio stream.</summary>
    Audio,
    /// <summary>A photo stream.</summary>
    Photo,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] Metadata,
  }
}
