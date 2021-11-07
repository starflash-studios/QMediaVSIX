// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.CameraStreamState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the state of a camera stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CameraStreamState
  {
    /// <summary>The camera stream is not currently streaming.</summary>
    NotStreaming,
    /// <summary>The camera stream is currently streaming.</summary>
    Streaming,
    /// <summary>Frames in the stream are being dropped for privacy reasons.</summary>
    BlockedForPrivacy,
    /// <summary>The camera stream has been shut down.</summary>
    Shutdown,
  }
}
