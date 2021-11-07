// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CapturedFrameControlValues
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  /// <summary>Provides information about the capture device settings that were used for a frame in a variable photo sequence.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class CapturedFrameControlValues : 
    ICapturedFrameControlValues,
    ICapturedFrameControlValues2
  {
    /// <summary>Gets the exposure time used for a frame in a variable photo sequence.</summary>
    /// <returns>Gets the exposure time used for a frame in a variable photo sequence.</returns>
    public extern IReference<TimeSpan> Exposure { [MethodImpl] get; }

    /// <summary>Gets the exposure compensation value used for a frame in a variable photo sequence.</summary>
    /// <returns>The exposure compensation value used for a frame in a variable photo sequence.</returns>
    public extern IReference<float> ExposureCompensation { [MethodImpl] get; }

    /// <summary>Gets the ISO speed used for a frame in a variable photo sequence.</summary>
    /// <returns>The ISO speed used for a frame in a variable photo sequence.</returns>
    public extern IReference<uint> IsoSpeed { [MethodImpl] get; }

    /// <summary>Gets the focus lens position used for a frame in a variable photo sequence.</summary>
    /// <returns>The focus lens position used for a frame in a variable photo sequence.</returns>
    public extern IReference<uint> Focus { [MethodImpl] get; }

    /// <summary>Gets the scene mode used for a frame in a variable photo sequence.</summary>
    /// <returns>The scene mode used for a frame in a variable photo sequence.</returns>
    public extern IReference<CaptureSceneMode> SceneMode { [MethodImpl] get; }

    /// <summary>Gets a value indicating if the flash was used for a frame in a variable photo sequence.</summary>
    /// <returns>A value indicating if the flash was used for a frame in a variable photo sequence.</returns>
    public extern IReference<bool> Flashed { [MethodImpl] get; }

    /// <summary>Gets the flash power used for a frame in a variable photo sequence.</summary>
    /// <returns>The flash power used for a frame in a variable photo sequence.</returns>
    public extern IReference<float> FlashPowerPercent { [MethodImpl] get; }

    /// <summary>Gets the white balance setting used for a frame in a variable photo sequence.</summary>
    /// <returns>The white balance setting used for a frame in a variable photo sequence.</returns>
    public extern IReference<uint> WhiteBalance { [MethodImpl] get; }

    /// <summary>Gets the zoom factor used for a frame in a variable photo sequence.</summary>
    /// <returns>The zoom factor used for a frame in a variable photo sequence.</returns>
    public extern IReference<float> ZoomFactor { [MethodImpl] get; }

    /// <summary>Gets the focus state for a frame in a variable photo sequence.</summary>
    /// <returns>The focus state for a frame in a variable photo sequence.</returns>
    public extern IReference<MediaCaptureFocusState> FocusState { [MethodImpl] get; }

    /// <summary>Gets the ISO digital gain used for a frame in a variable photo sequence.</summary>
    /// <returns>The ISO digital gain used for a frame in a variable photo sequence.</returns>
    public extern IReference<double> IsoDigitalGain { [MethodImpl] get; }

    /// <summary>Gets the ISO analog gain used for a frame in a variable photo sequence.</summary>
    /// <returns>The ISO analog gain used for a frame in a variable photo sequence.</returns>
    public extern IReference<double> IsoAnalogGain { [MethodImpl] get; }

    /// <summary>Gets the sensor frame rate used for a frame in a variable photo sequence.</summary>
    /// <returns>The sensor frame rate used for a frame in a variable photo sequence.</returns>
    public extern MediaRatio SensorFrameRate { [MethodImpl] get; }

    /// <summary>Gets the white balance gain used for a frame in a variable photo sequence.</summary>
    /// <returns>The white balance gain used for a frame in a variable photo sequence.</returns>
    public extern IReference<global::Windows.Media.Capture.WhiteBalanceGain> WhiteBalanceGain { [MethodImpl] get; }
  }
}
