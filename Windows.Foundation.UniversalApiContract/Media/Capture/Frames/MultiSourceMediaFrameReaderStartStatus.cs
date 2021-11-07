// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MultiSourceMediaFrameReaderStartStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Specifies the status of a MultiSourceMediaFrameReader start operation. A value from this enumeration is returned by the MultiSourceMediaFrameReader.StartAsync method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum MultiSourceMediaFrameReaderStartStatus
  {
    /// <summary>The frame reader was started successfully.</summary>
    Success,
    /// <summary>MultiSourceMediaFrameReader is not supported for the current device.</summary>
    NotSupported,
    /// <summary>The reader could not be started due to insufficient system resources.</summary>
    InsufficientResources,
    /// <summary>The reader could not be started because the capture device is unavailable.</summary>
    DeviceNotAvailable,
    /// <summary>There was an unknown failure</summary>
    UnknownFailure,
  }
}
