// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkUnprocessedInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3678684640, 33688, 18721, 172, 59, 171, 151, 140, 91, 162, 86)]
  [ExclusiveTo(typeof (InkUnprocessedInput))]
  internal interface IInkUnprocessedInput
  {
    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerEntered;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerHovered;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerExited;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerPressed;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerMoved;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerReleased;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerLost;

    InkPresenter InkPresenter { get; }
  }
}
