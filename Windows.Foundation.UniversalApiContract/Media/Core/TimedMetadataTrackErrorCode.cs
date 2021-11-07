// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataTrackErrorCode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the type of error that occurred with a TimedMetadataTrack.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedMetadataTrackErrorCode
  {
    /// <summary>No error code.</summary>
    None,
    /// <summary>The error was related to the format of the timed metadata track data.</summary>
    DataFormatError,
    /// <summary>A network error occurred.</summary>
    NetworkError,
    /// <summary>The error occurred internal to the system.</summary>
    InternalError,
  }
}
