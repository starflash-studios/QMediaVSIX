// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazePointPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.HumanInterfaceDevice;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Provides basic properties for the gaze input point associated with a single eye-tracking device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GazePointPreview : IGazePointPreview
  {
    /// <summary>Gets information about the eye-tracking device associated with the gaze input.</summary>
    /// <returns>A reference to the eye-tracking device.</returns>
    public extern GazeDevicePreview SourceDevice { [MethodImpl] get; }

    /// <summary>Gets the location, derived from the position and orientation of the user's eyes, of the gaze point.</summary>
    /// <returns>The screen coordinates of the gaze point are in device-independent pixels (DIP) relative to, and constrained by, the application view (or gaze-enabled element).</returns>
    public extern IReference<Point> EyeGazePosition { [MethodImpl] get; }

    /// <summary>Gets the location, derived from the user's head position and orientation, of the gaze point.</summary>
    /// <returns>The screen coordinates of the gaze point are in device-independent pixels (DIP) relative to, and constrained by, the application view (or gaze-enabled element).</returns>
    public extern IReference<Point> HeadGazePosition { [MethodImpl] get; }

    /// <summary>Gets the time of the gaze point input event.</summary>
    /// <returns>The time, relative to the system boot time, in microseconds.</returns>
    public extern ulong Timestamp { [MethodImpl] get; }

    /// <summary>Gets a Human Interface Device (HID) input report for the eye-tracking device.</summary>
    /// <returns>A HidInputReport object.</returns>
    public extern HidInputReport HidInputReport { [MethodImpl] get; }
  }
}
