// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the SearchBox.QueryChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SearchBoxQueryChangedEventArgs : ISearchBoxQueryChangedEventArgs
  {
    /// <summary>Gets the query text of the current search.</summary>
    /// <returns>The query text of the current search.</returns>
    public extern string QueryText { [MethodImpl] get; }

    /// <summary>Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language currently associated with the user's text input device.</summary>
    /// <returns>The IETF BCP 47 standard language tag.</returns>
    public extern string Language { [MethodImpl] get; }

    /// <summary>Gets information about query text that the user enters through an Input Method Editor (IME).</summary>
    /// <returns>Linguistic information about query text that the user enters through an Input Method Editor (IME).</returns>
    public extern SearchQueryLinguisticDetails LinguisticDetails { [MethodImpl] get; }
  }
}
