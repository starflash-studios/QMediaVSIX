// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalyzerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  /// <summary>Represents a factory for generating InkAnalyzer objects used in ink analysis.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(689145478, 6499, 18904, 149, 137, 225, 67, 132, 199, 105, 227)]
  public interface IInkAnalyzerFactory
  {
    /// <summary>Retrieves a new instance of an InkAnalyzer object.</summary>
    /// <returns>
    /// </returns>
    InkAnalyzer CreateAnalyzer();
  }
}
