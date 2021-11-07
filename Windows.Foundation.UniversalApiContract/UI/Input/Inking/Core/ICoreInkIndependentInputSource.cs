// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreInkIndependentInputSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking.Core
{
  [ExclusiveTo(typeof (CoreInkIndependentInputSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(968068521, 30265, 17561, 165, 181, 25, 29, 0, 227, 91, 22)]
  [WebHostHidden]
  internal interface ICoreInkIndependentInputSource
  {
    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerEntering;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerHovering;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerExiting;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerPressing;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerMoving;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerReleasing;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerLost;

    InkPresenter InkPresenter { get; }
  }
}
