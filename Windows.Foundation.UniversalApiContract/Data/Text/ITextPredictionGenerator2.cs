// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextPredictionGenerator2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Text.Core;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (TextPredictionGenerator))]
  [Guid(3091669944, 11383, 18538, 144, 10, 163, 69, 62, 237, 193, 93)]
  internal interface ITextPredictionGenerator2
  {
    [RemoteAsync]
    [Overload("GetCandidatesWithParametersAsync")]
    IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates,
      TextPredictionOptions predictionOptions,
      IIterable<string> previousStrings);

    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetNextWordCandidatesAsync(
      uint maxCandidates,
      IIterable<string> previousStrings);

    CoreTextInputScope InputScope { get; set; }
  }
}
