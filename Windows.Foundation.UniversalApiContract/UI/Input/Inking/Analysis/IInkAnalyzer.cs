// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalyzer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkAnalyzer))]
  [Guid(4046163861, 2150, 19909, 140, 119, 248, 134, 20, 223, 227, 140)]
  internal interface IInkAnalyzer
  {
    InkAnalysisRoot AnalysisRoot { get; }

    bool IsAnalyzing { get; }

    void AddDataForStroke(InkStroke stroke);

    void AddDataForStrokes(IIterable<InkStroke> strokes);

    void ClearDataForAllStrokes();

    void RemoveDataForStroke(uint strokeId);

    void RemoveDataForStrokes(IIterable<uint> strokeIds);

    void ReplaceDataForStroke(InkStroke stroke);

    void SetStrokeDataKind(uint strokeId, InkAnalysisStrokeKind strokeKind);

    [RemoteAsync]
    IAsyncOperation<InkAnalysisResult> AnalyzeAsync();
  }
}
