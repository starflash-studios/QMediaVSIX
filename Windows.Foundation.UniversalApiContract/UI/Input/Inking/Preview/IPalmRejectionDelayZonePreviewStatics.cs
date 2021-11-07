// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Preview.IPalmRejectionDelayZonePreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Input.Inking.Preview
{
  [ExclusiveTo(typeof (PalmRejectionDelayZonePreview))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(3455016672, 37840, 21417, 143, 14, 154, 55, 159, 143, 117, 48)]
  internal interface IPalmRejectionDelayZonePreviewStatics
  {
    [Overload("CreateForVisual")]
    PalmRejectionDelayZonePreview CreateForVisual(
      Visual inputPanelVisual,
      Rect inputPanelRect);

    [Overload("CreateForVisualWithViewportClip")]
    PalmRejectionDelayZonePreview CreateForVisual(
      Visual inputPanelVisual,
      Rect inputPanelRect,
      Visual viewportVisual,
      Rect viewportRect);
  }
}
