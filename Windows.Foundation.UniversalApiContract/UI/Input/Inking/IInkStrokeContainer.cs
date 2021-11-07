// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input.Inking
{
  /// <summary>Represents a manager for the collection of InkStroke objects rendered by the InkPresenter.</summary>
  [Guid(581749702, 64169, 20244, 182, 140, 246, 206, 230, 112, 174, 22)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IInkStrokeContainer
  {
    /// <summary>Gets the bounding rectangle of the InkStroke collection managed by the InkStrokeContainer.</summary>
    /// <returns>The bounding rectangle of the InkStroke collection.</returns>
    Rect BoundingRect { get; }

    /// <summary>Adds an InkStroke object to the collection managed by the InkStrokeContainer.</summary>
    /// <param name="stroke">The ink stroke to be added.</param>
    void AddStroke(InkStroke stroke);

    /// <summary>Deletes the selected InkStroke objects from the InkStroke collection managed by the InkStrokeContainer.</summary>
    /// <returns>The bounding rectangle of the selected ink strokes, or the invalidated rectangle (0, 0, 0, 0) if no strokes were removed (no selected strokes).</returns>
    Rect DeleteSelected();

    /// <summary>Moves the selected strokes. All affected strokes are re-rendered.</summary>
    /// <param name="translation">The destination screen coordinates for the upper-left corner of the bounding rectangle of the selected strokes.</param>
    /// <returns>The bounding rectangle of the selected ink strokes.</returns>
    Rect MoveSelected(Point translation);

    Rect SelectWithPolyLine(IIterable<Point> polyline);

    /// <summary>Selects all strokes intersected by the new stroke.</summary>
    /// <param name="from">The start of the line.</param>
    /// <param name="to">The end of the line.</param>
    /// <returns>The bounding rectangle of the selected ink strokes.</returns>
    Rect SelectWithLine(Point from, Point to);

    /// <summary>Copies the selected InkStroke objects (from the InkStroke collection managed by the InkStrokeContainer ) to the clipboard in Ink Serialized Format (ISF) format.</summary>
    void CopySelectedToClipboard();

    /// <summary>Adds the InkStroke content from the clipboard to the InkStroke collection that is managed by the InkStrokeContainer and renders the new strokes.</summary>
    /// <param name="position">The screen coordinates for the upper-left corner of the bounding rectangle of the clipboard content.</param>
    /// <returns>The invalidated bounding rectangle of the InkStroke collection.</returns>
    Rect PasteFromClipboard(Point position);

    /// <summary>Identifies whether content on the clipboard can be added to the InkStroke collection managed by the InkStrokeContainer.</summary>
    /// <returns>True if content can be pasted from the clipboard; otherwise, false.</returns>
    bool CanPasteFromClipboard();

    /// <summary>Asynchronously loads all InkStroke objects from the specified stream to the InkStroke collection that is managed by the InkStrokeContainer.</summary>
    /// <param name="inputStream">The stream that contains the stroke collection. An IRandomAccessStream (requires IOutputStream ) object can be specified instead.</param>
    /// <returns>The status of the asynchronous operation as the number of bytes fetched. For more information, see [ReadAsync](https://docs.microsoft.com/previous-versions/hh438388(v=vs.85)) method.</returns>
    [RemoteAsync]
    IAsyncActionWithProgress<ulong> LoadAsync(IInputStream inputStream);

    /// <summary>Asynchronously saves all InkStroke objects in the InkStroke collection that is managed by the InkStrokeContainer to the specified stream.</summary>
    /// <param name="outputStream">The target stream. An IRandomAccessStream (requires IOutputStream ) object can be specified instead.</param>
    /// <returns>The size of the saved stream and the status of the asynchronous operation as the number of bytes sent. For more information, see [WriteAsync](https://docs.microsoft.com/previous-versions/hh438392(v=vs.85)) method.</returns>
    [Overload("SaveAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream);

    void UpdateRecognitionResults(
      IVectorView<InkRecognitionResult> recognitionResults);

    /// <summary>Retrieves all ink strokes in the collection managed by the InkStrokeContainer.</summary>
    /// <returns>The ink strokes managed by the InkStrokeContainer as a collection of InkStroke objects.</returns>
    IVectorView<InkStroke> GetStrokes();

    /// <summary>Gets the collection of recognition matches previously processed by an InkRecognizer and stored in an InkRecognizerContainer.</summary>
    /// <returns>The results of the recognition as a collection of InkRecognitionResult objects.</returns>
    IVectorView<InkRecognitionResult> GetRecognitionResults();
  }
}
