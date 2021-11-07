// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkRecognizerContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Represents one or more InkRecognizer objects.</summary>
  [Guid(2806880817, 32839, 18072, 169, 18, 248, 42, 80, 133, 1, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IInkRecognizerContainer
  {
    /// <summary>Sets the default InkRecognizer used for handwriting recognition.</summary>
    /// <param name="recognizer">The InkRecognizer.</param>
    void SetDefaultRecognizer(InkRecognizer recognizer);

    /// <summary>Performs handwriting recognition on one or more InkStroke objects.</summary>
    /// <param name="strokeCollection">The set of strokes on which recognition is performed.</param>
    /// <param name="recognitionTarget">One of the values from the InkRecognitionTarget enumeration.</param>
    /// <returns>The results of the recognition as a collection of InkRecognitionResult objects.Each item in the collection represents a written word. For example, the string "this is a test" contains four words that are stored as a collection of four items.</returns>
    [RemoteAsync]
    IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkStrokeContainer strokeCollection,
      InkRecognitionTarget recognitionTarget);

    /// <summary>Gets the collection of installed handwriting recognizers.</summary>
    /// <returns>The installed handwriting recognizers as a collection of InkRecognizer objects.</returns>
    IVectorView<InkRecognizer> GetRecognizers();
  }
}
