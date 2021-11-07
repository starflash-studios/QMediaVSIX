// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Preview.Holographic.IHolographicKeyboardPlacementOverridePreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Preview.Holographic
{
  [Guid(539910201, 8182, 23046, 170, 196, 165, 226, 79, 163, 236, 75)]
  [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HolographicKeyboardPlacementOverridePreview))]
  internal interface IHolographicKeyboardPlacementOverridePreviewStatics
  {
    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    HolographicKeyboardPlacementOverridePreview GetForCurrentView();
  }
}
