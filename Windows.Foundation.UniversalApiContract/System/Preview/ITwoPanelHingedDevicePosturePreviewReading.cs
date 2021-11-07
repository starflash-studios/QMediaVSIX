// Decompiled with JetBrains decompiler
// Type: Windows.System.Preview.ITwoPanelHingedDevicePosturePreviewReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Preview
{
  [ExclusiveTo(typeof (TwoPanelHingedDevicePosturePreviewReading))]
  [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2686784594, 19158, 19256, 132, 38, 197, 154, 21, 73, 58, 125)]
  internal interface ITwoPanelHingedDevicePosturePreviewReading
  {
    DateTime Timestamp { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    HingeState HingeState { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    SimpleOrientation Panel1Orientation { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    string Panel1Id { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    SimpleOrientation Panel2Orientation { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    string Panel2Id { [Deprecated("TwoPanelHingedDevicePosturePreviewReading is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
