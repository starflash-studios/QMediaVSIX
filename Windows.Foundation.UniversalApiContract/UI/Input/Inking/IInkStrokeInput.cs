// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStrokeInput))]
  [Guid(3476029051, 24080, 17350, 160, 128, 136, 242, 110, 29, 198, 125)]
  internal interface IInkStrokeInput
  {
    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeStarted;

    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeContinued;

    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeEnded;

    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeCanceled;

    InkPresenter InkPresenter { get; }
  }
}
