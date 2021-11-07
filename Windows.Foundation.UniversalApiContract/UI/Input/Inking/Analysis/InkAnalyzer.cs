// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalyzer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  /// <summary>Provides access to an object that can categorize ink strokes into either writing or drawing strokes, and recognize text, shapes, and basic layout structures.</summary>
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkAnalyzer : IInkAnalyzer
  {
    /// <summary>Creates a new InkAnalyzer object to manage InkAnalysisNode objects generated from ink analysis.</summary>
    [MethodImpl]
    public extern InkAnalyzer();

    /// <summary>Gets the root node of the ink analysis results.</summary>
    /// <returns>
    /// </returns>
    public extern InkAnalysisRoot AnalysisRoot { [MethodImpl] get; }

    /// <summary>Gets the state of the ink analysis process.</summary>
    /// <returns>
    /// </returns>
    public extern bool IsAnalyzing { [MethodImpl] get; }

    /// <summary>Adds data for a single ink stroke to the ink analysis results.</summary>
    /// <param name="stroke">The ink stroke from which to extract the data to add to the ink analysis results.</param>
    [MethodImpl]
    public extern void AddDataForStroke(InkStroke stroke);

    [MethodImpl]
    public extern void AddDataForStrokes(IIterable<InkStroke> strokes);

    /// <summary>Delete all nodes from the last ink analysis process.</summary>
    [MethodImpl]
    public extern void ClearDataForAllStrokes();

    /// <summary>Delete all nodes for the specified ink stroke from the last ink analysis process.</summary>
    /// <param name="strokeId">The unique identifier of the ink stroke.</param>
    [MethodImpl]
    public extern void RemoveDataForStroke(uint strokeId);

    [MethodImpl]
    public extern void RemoveDataForStrokes(IIterable<uint> strokeIds);

    /// <summary>Update all nodes for the specified ink stroke from the last ink analysis process.</summary>
    /// <param name="stroke">
    /// </param>
    [MethodImpl]
    public extern void ReplaceDataForStroke(InkStroke stroke);

    /// <summary>Sets the ink analysis category for the InkAnalysisNode associated with the ink stroke.</summary>
    /// <param name="strokeId">The unique identifier for the ink stroke being categorized.</param>
    /// <param name="strokeKind">The InkAnalysisStrokeKind category to assign to the InkAnalysisNode.</param>
    [MethodImpl]
    public extern void SetStrokeDataKind(uint strokeId, InkAnalysisStrokeKind strokeKind);

    /// <summary>Aynchronously generates the tree of objects for the ink analysis process.</summary>
    /// <returns>The results of the analysis as an InkAnalysisResult object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<InkAnalysisResult> AnalyzeAsync();
  }
}
