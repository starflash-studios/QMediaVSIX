// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeBuilder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(2193347036, 7267, 16860, 158, 7, 75, 74, 112, 206, 216, 1)]
  [ExclusiveTo(typeof (InkStrokeBuilder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkStrokeBuilder
  {
    void BeginStroke(PointerPoint pointerPoint);

    PointerPoint AppendToStroke(PointerPoint pointerPoint);

    InkStroke EndStroke(PointerPoint pointerPoint);

    InkStroke CreateStroke(IIterable<Point> points);

    void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);
  }
}
