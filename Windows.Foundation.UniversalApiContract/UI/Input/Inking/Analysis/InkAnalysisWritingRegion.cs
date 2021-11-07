// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalysisWritingRegion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  /// <summary>Provides access to an InkAnalysisNode of type InkAnalysisNodeKind.WritingRegion.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkAnalysisWritingRegion : IInkAnalysisWritingRegion, IInkAnalysisNode
  {
    /// <summary>Gets the recognized text associated with the InkAnalysisWritingRegion object.</summary>
    /// <returns>
    /// </returns>
    public extern string RecognizedText { [MethodImpl] get; }

    /// <summary>Gets the unique identifier of the InkAnalysisWritingRegion object.</summary>
    /// <returns>
    /// </returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the kind of ink input identified by the InkAnalysisWritingRegion object.</summary>
    /// <returns>
    /// </returns>
    public extern InkAnalysisNodeKind Kind { [MethodImpl] get; }

    /// <summary>Gets the bounding rectangle of the InkAnalysisWritingRegion object.</summary>
    /// <returns>The X, Y coordinates (top left) and dimensions (length and width) of the bounding box for the InkAnalysisWritingRegion object, in device-independent pixels (DIPs) relative to the upper left-hand corner of the inking area.</returns>
    public extern Rect BoundingRect { [MethodImpl] get; }

    /// <summary>Gets the oriented and snapped, bounding rectangle of the InkAnalysisWritingRegion object. </summary>
    /// <returns>The X, Y coordinates for each vertex point of the bounding box for the InkAnalysisWritingRegion object, in device-independent pixels (DIPs) relative to the upper left-hand corner of the inking area.</returns>
    public extern IVectorView<Point> RotatedBoundingRect { [MethodImpl] get; }

    /// <summary>Gets all child nodes of the InkAnalysisWritingRegion object.</summary>
    /// <returns>
    /// </returns>
    public extern IVectorView<IInkAnalysisNode> Children { [MethodImpl] get; }

    /// <summary>Gets the parent node of the InkAnalysisWritingRegion object.</summary>
    /// <returns>
    /// </returns>
    public extern IInkAnalysisNode Parent { [MethodImpl] get; }

    /// <summary>Retrieves the unique identifiers of all nodes belonging to the InkAnalysisWritingRegion object.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern IVectorView<uint> GetStrokeIds();
  }
}
