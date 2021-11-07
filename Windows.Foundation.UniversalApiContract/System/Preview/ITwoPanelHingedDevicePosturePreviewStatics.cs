// Decompiled with JetBrains decompiler
// Type: Windows.System.Preview.ITwoPanelHingedDevicePosturePreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Preview
{
  [Guid(205992914, 22496, 16768, 189, 94, 243, 26, 33, 56, 66, 62)]
  [Deprecated("TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (TwoPanelHingedDevicePosturePreview))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ITwoPanelHingedDevicePosturePreviewStatics
  {
    [Deprecated("TwoPanelHingedDevicePosturePreview is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<TwoPanelHingedDevicePosturePreview> GetDefaultAsync();
  }
}
