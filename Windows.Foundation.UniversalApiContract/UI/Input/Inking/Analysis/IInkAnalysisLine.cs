// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisLine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [Guid(2691499149, 11149, 18260, 173, 90, 208, 135, 17, 147, 169, 86)]
  [ExclusiveTo(typeof (InkAnalysisLine))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkAnalysisLine : IInkAnalysisNode
  {
    string RecognizedText { get; }

    int IndentLevel { get; }
  }
}
