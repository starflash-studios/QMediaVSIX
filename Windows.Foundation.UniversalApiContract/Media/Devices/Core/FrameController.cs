// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Represents the settings for a frame in a variable photo sequence.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class FrameController : IFrameController, IFrameController2
  {
    /// <summary>Initializes a new instance of the FrameController class.</summary>
    [MethodImpl]
    public extern FrameController();

    /// <summary>Gets the exposure settings for a frame in a variable photo sequence.</summary>
    /// <returns>The exposure settings for a frame in a variable photo sequence.</returns>
    public extern FrameExposureControl ExposureControl { [MethodImpl] get; }

    /// <summary>Gets the exposure compensation settings for a frame in a variable photo sequence.</summary>
    /// <returns>The exposure compensation settings for a frame in a variable photo sequence.</returns>
    public extern FrameExposureCompensationControl ExposureCompensationControl { [MethodImpl] get; }

    /// <summary>Gets the ISO speed settings for a frame in a variable photo sequence.</summary>
    /// <returns>The ISO speed settings for a frame in a variable photo sequence.</returns>
    public extern FrameIsoSpeedControl IsoSpeedControl { [MethodImpl] get; }

    /// <summary>Gets the focus settings for a frame in a variable photo sequence.</summary>
    /// <returns>The focus settings for a frame in a variable photo sequence.</returns>
    public extern FrameFocusControl FocusControl { [MethodImpl] get; }

    /// <summary>Gets or sets whether photo confirmation is enabled for a frame in a variable photo sequence.</summary>
    /// <returns>Whether photo confirmation is enabled for a frame in a variable photo sequence.</returns>
    public extern IReference<bool> PhotoConfirmationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the flash settings for a frame in a variable photo sequence.</summary>
    /// <returns>The flash settings for a frame in a variable photo sequence.</returns>
    public extern FrameFlashControl FlashControl { [MethodImpl] get; }
  }
}
