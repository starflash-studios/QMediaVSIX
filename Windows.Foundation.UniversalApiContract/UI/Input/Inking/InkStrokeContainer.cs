// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeContainer
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
  /// <summary>Provides properties and methods to store and manage the collection of InkStroke objects rendered by the InkPresenter.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InkStrokeContainer : 
    IInkStrokeContainer,
    IInkStrokeContainer2,
    IInkStrokeContainer3
  {
    /// <summary>Initializes a new InkStrokeContainer object that is used to manage InkStroke objects.</summary>
    [MethodImpl]
    public extern InkStrokeContainer();

    /// <summary>Gets the bounding rectangle of the InkStroke collection managed by the InkStrokeContainer.</summary>
    /// <returns>The bounding rectangle of the InkStroke collection.</returns>
    public extern Rect BoundingRect { [MethodImpl] get; }

    /// <summary>Adds an InkStroke object to the collection managed by the InkStrokeContainer.</summary>
    /// <param name="stroke">The ink stroke to be added.</param>
    [MethodImpl]
    public extern void AddStroke(InkStroke stroke);

    /// <summary>Deletes the selected InkStroke objects from the InkStroke collection managed by the InkStrokeContainer.</summary>
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
    /// <param name="from">The start of the line.</param>
    /// <param name="to">The of the line.</param>
    /// <returns>The bounding rectangle of the selected ink strokes.</returns>
    [MethodImpl]
    public extern Rect SelectWithLine(Point from, Point to);

    /// <summary>Copies the selected InkStroke objects (from the InkStroke collection managed by the InkStrokeContainer ) to the clipboard in Ink Serialized Format (ISF) format.</summary>
    [MethodImpl]
    public extern void CopySelectedToClipboard();

    /// <summary>Adds the InkStroke content from the clipboard to the InkStroke collection that is managed by the InkStrokeContainer and renders the new strokes..</summary>
    /// <param name="position">The screen coordinates for the upper-left corner of the bounding rectangle of the clipboard content.</param>
    /// <returns>The invalidated bounding rectangle of the InkStroke collection.</returns>
    [MethodImpl]
    public extern Rect PasteFromClipboard(Point position);

    /// <summary>Identifies whether content on the clipboard can be added to the InkStroke collection managed by the InkStrokeContainer.</summary>
    /// <returns>True if content can be pasted from the clipboard; otherwise, false.</returns>
    [MethodImpl]
    public extern bool CanPasteFromClipboard();

    /// <summary>Asynchronously loads all InkStroke objects from the specified stream to the InkStroke collection that is managed by the InkStrokeContainer.</summary>
    /// <param name="inputStream">The target stream.</param>
    /// <returns>The status of the asynchronous operation as the number of bytes fetched. For more information, see [ReadAsync](https://docs.microsoft.com/previous-versions/hh438388(v=vs.85)) method.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<ulong> LoadAsync(
      IInputStream inputStream);

    /// <summary>Asynchronously saves all InkStroke objects in the InkStroke collection that is managed by the InkStrokeContainer to the specified stream.</summary>
    /// <param name="outputStream">The target stream. An IRandomAccessStream (requires IOutputStream ) object can be specified instead.</param>
    /// <returns>The status of the asynchronous operation as the number of bytes sent. For more information, see [WriteAsync](https://docs.microsoft.com/previous-versions/hh438392(v=vs.85)) method.</returns>
    [RemoteAsync]
    [Overload("SaveAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void UpdateRecognitionResults(
      IVectorView<InkRecognitionResult> recognitionResults);

    /// <summary>Retrieves all ink strokes in the collection managed by the InkStrokeContainer.</summary>
    /// <returns>The ink strokes managed by the InkStrokeContainer as a collection of InkStroke objects.</returns>
    [MethodImpl]
    public extern IVectorView<InkStroke> GetStrokes();

    /// <summary>Gets the collection of recognition matches previously processed by an InkRecognizer and stored in an InkRecognizerContainer.</summary>
    /// <returns>The results of the recognition as a collection of InkRecognitionResult objects.</returns>
    [MethodImpl]
    public extern IVectorView<InkRecognitionResult> GetRecognitionResults();

    [MethodImpl]
    public extern void AddStrokes(IIterable<InkStroke> strokes);

    /// <summary>Deletes all InkStroke objects from the collection managed by the InkStrokeContainer.</summary>
    [MethodImpl]
    public extern void Clear();

    /// <summary>Asynchronously saves all InkStroke objects in the InkStroke collection that is managed by the InkStrokeContainer to the specified stream and in the specified format.</summary>
    /// <param name="outputStream">The target stream. An IRandomAccessStream (requires IOutputStream ) object can be specified instead.</param>
    /// <param name="inkPersistenceFormat">The format in which to save the ink input.</param>
    /// <returns>The status of the asynchronous operation as the number of bytes sent. For more information, see [WriteAsync](https://docs.microsoft.com/previous-versions/hh438392(v=vs.85)) method.</returns>
    [RemoteAsync]
    [Overload("SaveWithFormatAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream,
      InkPersistenceFormat inkPersistenceFormat);

    /// <summary>Retrieves the single InkStroke with the specified ID.</summary>
    /// <param name="id">The Global Unique Identifier (GUID) used to identify a single ink stroke.</param>
    /// <returns>The single ink stroke.</returns>
    [MethodImpl]
    public extern InkStroke GetStrokeById(uint id);
  }
}
