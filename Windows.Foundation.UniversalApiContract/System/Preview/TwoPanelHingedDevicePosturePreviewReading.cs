// Decompiled with JetBrains decompiler
// Type: Windows.System.Preview.TwoPanelHingedDevicePosturePreviewReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Preview
{
  /// <summary>A snapshot of the device's posture information at a moment in time.</summary>
  /// <deprecated type="deprecate">TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class TwoPanelHingedDevicePosturePreviewReading : 
    ITwoPanelHingedDevicePosturePreviewReading
  {
    /// <summary>Describes when a TwoPanelHingedDevicePosturePreviewReading was taken.</summary>
    /// <returns>The timestamp when the reading was taken.</returns>
    public extern DateTime Timestamp { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The hinge state of the device.</summary>
    /// <returns>The device's hinge state.</returns>
    public extern HingeState HingeState { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Describes the orientation of the device's first panel at the time the reading was taken.</summary>
    /// <returns>The first panel's orientation.</returns>
    public extern SimpleOrientation Panel1Orientation { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Describes the id of the device's 1st panel.</summary>
    /// <returns>The 1st panel's id.</returns>
    public extern string Panel1Id { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Describes the orientation of the device's second panel at the time the reading was taken.</summary>
    /// <returns>The second panel's orientation.</returns>
    public extern SimpleOrientation Panel2Orientation { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Describes the id of the device's second panel.</summary>
    /// <returns>The second panel's id.</returns>
    public extern string Panel2Id { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
