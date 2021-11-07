// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkManager))]
  [Guid(1195668349, 26395, 16739, 156, 149, 78, 141, 122, 3, 95, 225)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkManager : IInkStrokeContainer, IInkRecognizerContainer
  {
    InkManipulationMode Mode { get; set; }

    void ProcessPointerDown(PointerPoint pointerPoint);

    [return: Variant]
    object ProcessPointerUpdate(PointerPoint pointerPoint);

    Rect ProcessPointerUp(PointerPoint pointerPoint);

    void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);

    [RemoteAsync]
    [Overload("RecognizeAsync2")]
    IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkRecognitionTarget recognitionTarget);
  }
}
