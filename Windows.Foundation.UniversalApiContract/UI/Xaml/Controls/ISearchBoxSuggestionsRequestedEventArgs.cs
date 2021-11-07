// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxSuggestionsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SearchBoxSuggestionsRequestedEventArgs))]
  [Guid(3658815246, 58726, 18635, 189, 17, 254, 75, 15, 48, 164, 77)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISearchBoxSuggestionsRequestedEventArgs
  {
    string QueryText { get; }

    string Language { get; }

    SearchQueryLinguisticDetails LinguisticDetails { get; }

    SearchSuggestionsRequest Request { get; }
  }
}
