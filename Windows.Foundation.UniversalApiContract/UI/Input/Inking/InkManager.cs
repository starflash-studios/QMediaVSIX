// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input.Inking
{
  /// <summary>Manages the input, manipulation, and processing (including handwriting recognition) of one or more InkStroke objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.None)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class InkManager : IInkManager, IInkRecognizerContainer, IInkStrokeContainer
  {
    /// <summary>Creates a new InkManager object that is used to manage InkStroke objects.</summary>
    [MethodImpl]
    public extern InkManager();

    /// <summary>Gets or sets the ink input mode.</summary>
    /// <returns>The mode.</returns>
    public extern InkManipulationMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Processes information about the position and features of the contact point, like pressure and tilt, on initial down contact. You must call this method before you call ProcessPointerUpdate, and then ProcessPointerUp.</summary>
    /// <param name="pointerPoint">Information about the position and features of the contact point.</param>
    [MethodImpl]
    public extern void ProcessPointerDown(PointerPoint pointerPoint);

    /// <summary>Processes position and state properties, such as pressure and tilt, for the specified pointer, from the last pointer event up to and including the current pointer event.Call this method after ProcessPointerDown and before ProcessPointerUp.</summary>
    /// <param name="pointerPoint">The input pointer for which updates are to be processed.</param>
    /// <returns>When the current InkManipulationMode is **Inking** or **Selecting**, this method returns the Point (screen position in ink space) associated with the last ProcessPointerUpdate of *pointerPoint*.</returns>
    [MethodImpl]
    [return: Variant]
    public extern object ProcessPointerUpdate(PointerPoint pointerPoint);

    /// <summary>Processes information about the position and features of the contact point, like pressure and tilt, on up contact. You must call this method after you call ProcessPointerUpdate.</summary>
    /// <param name="pointerPoint">Information about the position and features of the contact point.</param>
    /// <returns>For Inking and Selecting modes, this is the bounding box for the stroke (invalidated rectangle). For Erasing mode, the invalidated rectangle is (0,0,0,0).</returns>
    [MethodImpl]
    public extern Rect ProcessPointerUp(PointerPoint pointerPoint);

    /// <summary>Sets the default InkDrawingAttributes for all new InkStroke objects added to the InkStroke collection managed by the InkManager.</summary>
    /// <param name="drawingAttributes">The default attributes applied to a new ink stroke.</param>
    [MethodImpl]
    public extern void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);

    /// <summary>Performs handwriting recognition on one or more InkStroke objects.</summary>
    /// <param name="recognitionTarget">One of the values from the InkRecognitionTarget enumeration.</param>
    /// <returns>The results of the recognition as a collection of InkRecognitionResult objects. Each item in the results returned by recognition represents one written word. Each word is associated with a ranked list of text strings (retrieved through a call to GetTextCandidates ) as potential matches for the word.</returns>
    [Overload("RecognizeAsync2")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkRecognitionTarget recognitionTarget);

    /// <summary>Gets the bounding rectangle of the InkStroke collection that is managed by the InkManager.</summary>
    /// <returns>The bounding rectangle of the InkStroke collection.</returns>
    public extern Rect BoundingRect { [MethodImpl] get; }

    /// <summary>Adds one or more InkStroke objects to the collection managed by the InkManager.</summary>
    /// <param name="stroke">The ink stroke to be added.</param>
    [MethodImpl]
    public extern void AddStroke(InkStroke stroke);

    /// <summary>Deletes the selected InkStroke objects from the InkStroke collection managed by the InkManager.</summary>
    /// <returns>The bounding rectangle of the selected ink strokes, or the invalidated rectangle (0, 0, 0, 0) if no strokes were removed (no selected strokes).</returns>
    [MethodImpl]
    public extern Rect DeleteSelected();

    /// <summary>Moves the selected strokes. All affected strokes are re-rendered.</summary>
    /// <param name="translation">The destination screen coordinates for the upper-left corner of the bounding rectangle of the selected strokes.</param>
    /// <returns>The bounding rectangle of the selected ink strokes.</returns>
    [MethodImpl]
    public extern Rect MoveSelected(Point translation);

    [MethodImpl]
    public extern Rect SelectWithPolyLine(IIterable<Point> polyline);

    /// <summary>Selects all strokes intersected by the new stroke.</summary>
    /// <param name="from">The start of the stroke.</param>
    /// <param name="to">The end of the stroke.</param>
    /// <returns>The bounding rectangle of the selected ink strokes.</returns>
    [MethodImpl]
    public extern Rect SelectWithLine(Point from, Point to);

    /// <summary>Copies the selected InkStroke objects (from the InkStroke collection managed by the InkManager ) to the clipboard in Ink Serialized Format (ISF) format.</summary>
    [MethodImpl]
    public extern void CopySelectedToClipboard();

    /// <summary>Adds the InkStroke content from the clipboard to the InkStroke collection that is managed by the InkManager and renders the new strokes..</summary>
    /// <param name="position">The screen coordinates for the upper-left corner of the bounding rectangle of the clipboard content.</param>
    /// <returns>The invalidated bounding rectangle of the InkStroke collection.</returns>
    [MethodImpl]
    public extern Rect PasteFromClipboard(Point position);

    /// <summary>Identifies whether content on the clipboard can be added to the InkStroke collection that is managed by the InkManager.</summary>
    /// <returns>True if content can be pasted from the clipboard; otherwise, false.</returns>
    [MethodImpl]
    public extern bool CanPasteFromClipboard();

    /// <summary>Asynchronously loads all InkStroke objects from the specified stream to the InkStroke collection that is managed by the InkManager.</summary>
    /// <param name="inputStream">The stream that contains the stroke collection. An IRandomAccessStream (requires IOutputStream ) object can be specified instead.</param>
    /// <returns>The status of the asynchronous operation as the number of bytes fetched. For more information, see [ReadAsync](https://docs.microsoft.com/previous-versions/hh438388(v=vs.85)) method.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<ulong> LoadAsync(
      IInputStream inputStream);

    /// <summary>Asynchronously saves all InkStroke objects in the InkStroke collection that is managed by the InkManager to the specified stream.</summary>
    /// <param name="outputStream">The target stream. An IRandomAccessStream (requires IOutputStream ) object can be specified instead.</param>
    /// <returns>The size of the saved stream and the status of the asynchronous operation as the number of bytes sent. For more information, see [WriteAsync](https://docs.microsoft.com/previous-versions/hh438392(v=vs.85)) method.</returns>
    [RemoteAsync]
    [Overload("SaveAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void UpdateRecognitionResults(
      IVectorView<InkRecognitionResult> recognitionResults);

    /// <summary>Retrieves all ink strokes in the collection managed by the InkManager.</summary>
    /// <returns>The ink strokes managed by the InkManager as a collection of InkStroke objects.</returns>
    [MethodImpl]
    public extern IVectorView<InkStroke> GetStrokes();

    /// <summary>Retrieves the collection of words returned by handwriting recognition.</summary>
    /// <returns>The words returned by the handwriting recognizer as a collection of InkRecognitionResult objects.</returns>
    [MethodImpl]
    public extern IVectorView<InkRecognitionResult> GetRecognitionResults();

    /// <summary>Sets the default InkRecognizer used for handwriting recognition.</summary>
    /// <param name="recognizer">The InkRecognizer.</param>
    [MethodImpl]
    public extern void SetDefaultRecognizer(InkRecognizer recognizer);

    /// <summary>Performs handwriting recognition on one or more InkStroke objects.</summary>
    /// <param name="strokeCollection">The set of strokes on which recognition is performed.</param>
    /// <param name="recognitionTarget">One of the values from the InkRecognitionTarget enumeration.</param>
    /// <returns>The results of the recognition as a collection of InkRecognitionResult objects.Each item in the results returned by recognition represents one written word. Each word is associated with a ranked list of text strings (retrieved through a call to GetTextCandidates ) as potential matches for the word.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkStrokeContainer strokeCollection,
      InkRecognitionTarget recognitionTarget);

    /// <summary>Gets the collection of installed handwriting recognizers.</summary>
    /// <returns>The installed handwriting recognizers as a collection of InkRecognizer objects.</returns>
    [MethodImpl]
    public extern IVectorView<InkRecognizer> GetRecognizers();
  }
}
