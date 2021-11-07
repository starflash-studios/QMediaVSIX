// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackSessionVideoConstrictionReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the policy-based reason that video output of a media item is constricted.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum MediaPlaybackSessionVideoConstrictionReason
  {
    /// <summary>The content is not currently being constricted.</summary>
    None,
    /// <summary>The content is being played back on a virtual machine.</summary>
    VirtualMachine,
    /// <summary>The content is being displayed on an unsupported display adapter.</summary>
    UnsupportedDisplayAdapter,
    /// <summary>The content is being displayed by a device with an unsigned driver.</summary>
    UnsignedDriver,
    /// <summary>The content is being rendered in a MediaPlayer with IsVideoFrameServerEnabled, providing direct access to video frames to the app.</summary>
    FrameServerEnabled,
    /// <summary>Output protection for the content failed.</summary>
    OutputProtectionFailed,
    /// <summary>The reason is unknown.</summary>
    Unknown,
  }
}
