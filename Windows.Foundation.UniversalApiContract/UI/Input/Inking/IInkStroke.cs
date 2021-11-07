// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStroke
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStroke))]
  [Guid(353652064, 52451, 20431, 157, 82, 17, 81, 138, 182, 175, 212)]
  internal interface IInkStroke
  {
    InkDrawingAttributes DrawingAttributes { get; set; }

    Rect BoundingRect { get; }

    bool Selected { get; set; }

    bool Recognized { get; }

    IVectorView<InkStrokeRenderingSegment> GetRenderingSegments();

    InkStroke Clone();
  }
}
