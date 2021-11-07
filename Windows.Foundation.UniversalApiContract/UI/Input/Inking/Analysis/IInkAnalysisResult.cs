// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ExclusiveTo(typeof (InkAnalysisResult))]
  [Guid(2303244921, 41539, 19107, 162, 148, 31, 152, 189, 15, 245, 128)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkAnalysisResult
  {
    InkAnalysisStatus Status { get; }
  }
}
