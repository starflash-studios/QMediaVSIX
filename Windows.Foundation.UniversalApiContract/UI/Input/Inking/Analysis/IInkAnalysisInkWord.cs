// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisInkWord
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [Guid(1272064173, 33711, 16436, 143, 59, 248, 104, 125, 255, 244, 54)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkAnalysisInkWord))]
  internal interface IInkAnalysisInkWord : IInkAnalysisNode
  {
    string RecognizedText { get; }

    IVectorView<string> TextAlternates { get; }
  }
}
