// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisListItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ExclusiveTo(typeof (InkAnalysisListItem))]
  [Guid(3034825279, 50371, 19514, 161, 166, 157, 133, 84, 126, 229, 134)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkAnalysisListItem : IInkAnalysisNode
  {
    string RecognizedText { get; }
  }
}
