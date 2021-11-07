// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackItemErrorCode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the type of error that occurred while opening a MediaPlaybackItem.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaPlaybackItemErrorCode
  {
    /// <summary>No error code.</summary>
    None,
    /// <summary>Opening of the playback item was aborted.</summary>
    Aborted,
    /// <summary>A network error occurred while opening the playback item.</summary>
    NetworkError,
    /// <summary>An error occurred while decoding the playback item.</summary>
    DecodeError,
    /// <summary>The media source of the playback item is not supported.</summary>
    SourceNotSupportedError,
    /// <summary>An error occurred related to the playback item's encryption.</summary>
    EncryptionError,
  }
}
