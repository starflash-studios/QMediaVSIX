// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameReaderStartStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Specifies the result of a call to StartAsync to start the reading of media frames by a MediaFrameReader.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaFrameReaderStartStatus
  {
    /// <summary>The operation was successful.</summary>
    Success,
    /// <summary>The operation failed for an unknown reason.</summary>
    UnknownFailure,
    /// <summary>The operation failed because the media frame source device is unavailable.</summary>
    DeviceNotAvailable,
    /// <summary>The operation failed because the requested output format is not supported by the media frame source.</summary>
    OutputFormatNotSupported,
    /// <summary>The operation failed because exclusive control of the media frame source device is unavailable.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] ExclusiveControlNotAvailable,
  }
}
