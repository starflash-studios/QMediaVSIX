// Decompiled with JetBrains decompiler
// Type: Windows.System.Preview.ITwoPanelHingedDevicePosturePreviewReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Preview
{
  [Deprecated("TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Guid(757930950, 718, 18250, 165, 86, 167, 91, 28, 249, 58, 3)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs))]
  internal interface ITwoPanelHingedDevicePosturePreviewReadingChangedEventArgs
  {
    TwoPanelHingedDevicePosturePreviewReading Reading { [Deprecated("TwoPanelHingedDevicePosturePreviewReadingChangedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
