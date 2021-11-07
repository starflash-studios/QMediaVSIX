// Decompiled with JetBrains decompiler
// Type: Windows.System.Preview.TwoPanelHingedDevicePosturePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Preview
{
  /// <summary>Provides information about the device posture, including hinge state and orientation.</summary>
  /// <deprecated type="deprecate">TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITwoPanelHingedDevicePosturePreviewStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Deprecated("TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class TwoPanelHingedDevicePosturePreview : ITwoPanelHingedDevicePosturePreview
  {
    /// <summary>Gets the current device posture.</summary>
    /// <deprecated type="deprecate">TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <returns>A TwoPanelHingedDevicePosturePreviewReading representing the current posture.</returns>
    [RemoteAsync]
    [Deprecated("TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<TwoPanelHingedDevicePosturePreviewReading> GetCurrentPostureAsync();

    /// <summary>Occurs when the device posture has changed.</summary>
    public extern event TypedEventHandler<TwoPanelHingedDevicePosturePreview, TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs> PostureChanged;

    /// <summary>Gets the default posture for the device.</summary>
    /// <deprecated type="deprecate">TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <returns>A TwoPanelHingedDevicePosturePreview representing the default posture for the device.</returns>
    [Deprecated("TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<TwoPanelHingedDevicePosturePreview> GetDefaultAsync();
  }
}
