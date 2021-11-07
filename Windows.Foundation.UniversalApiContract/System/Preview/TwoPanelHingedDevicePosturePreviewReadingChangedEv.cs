// Decompiled with JetBrains decompiler
// Type: Windows.System.Preview.TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Preview
{
  /// <summary>Contains information about a TwoPanelHingedDevicePosturePreviewReadingChanged event</summary>
  /// <deprecated type="deprecate">TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Deprecated("TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs : 
    ITwoPanelHingedDevicePosturePreviewReadingChangedEventArgs
  {
    /// <summary>The TwoPanelHingedDevicePosturePreviewReading that is passed along with the TwoPanelHingedDevicePosturePreviewReadingChangedEvent.</summary>
    /// <returns>The device posture reading associated with a posture changed event.</returns>
    public extern TwoPanelHingedDevicePosturePreviewReading Reading { [Deprecated("TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
