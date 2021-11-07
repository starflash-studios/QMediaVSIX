// Decompiled with JetBrains decompiler
// Type: Windows.System.Preview.ITwoPanelHingedDevicePosturePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Preview
{
  [ExclusiveTo(typeof (TwoPanelHingedDevicePosturePreview))]
  [Deprecated("TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Guid(1914985521, 19257, 17062, 142, 115, 114, 53, 173, 225, 104, 83)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ITwoPanelHingedDevicePosturePreview
  {
    [Deprecated("TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<TwoPanelHingedDevicePosturePreviewReading> GetCurrentPostureAsync();

    event TypedEventHandler<TwoPanelHingedDevicePosturePreview, TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs> PostureChanged;
  }
}
