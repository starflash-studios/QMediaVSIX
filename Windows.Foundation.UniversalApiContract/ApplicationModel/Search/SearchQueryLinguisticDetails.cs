// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.SearchQueryLinguisticDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  /// <summary>Provides information about query text that the user enters through an Input Method Editor (IME).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISearchQueryLinguisticDetailsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SearchQueryLinguisticDetails : ISearchQueryLinguisticDetails
  {
    [MethodImpl]
    public extern SearchQueryLinguisticDetails(
      IIterable<string> queryTextAlternatives,
      uint queryTextCompositionStart,
      uint queryTextCompositionLength);

    /// <summary>A list of the text alternatives for the current query text. These alternatives account for uncomposed text the user is entering in an IME.</summary>
    /// <returns>A list of the text alternatives for the query text.</returns>
    public extern IVectorView<string> QueryTextAlternatives { [MethodImpl] get; }

    /// <summary>The starting location of the text that the user is composing with an Input Method Editor (IME).</summary>
    /// <returns>The starting location of the query text that the user is composing with an Input Method Editor (IME).</returns>
    public extern uint QueryTextCompositionStart { [MethodImpl] get; }

    /// <summary>The length of the portion of the query text that the user is composing with an Input Method Editor (IME).</summary>
    /// <returns>The length of the portion of the query text that the user is composing with an Input Method Editor (IME).</returns>
    public extern uint QueryTextCompositionLength { [MethodImpl] get; }
  }
}
