// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the SearchBox.ResultSuggestionChosen event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SearchBoxResultSuggestionChosenEventArgs : 
    ISearchBoxResultSuggestionChosenEventArgs
  {
    /// <summary>Initializes a new instance of the SearchBoxResultSuggestionChosenEventArgs class.</summary>
    [MethodImpl]
    public extern SearchBoxResultSuggestionChosenEventArgs();

    /// <summary>The app-defined tag for the suggested result that the user selected.</summary>
    /// <returns>The app-defined tag for the selected search result.</returns>
    public extern string Tag { [MethodImpl] get; }

    /// <summary>Gets any modifier keys that are pressed when the user presses enter to pick a search result.</summary>
    /// <returns>Any modifier keys that are pressed when the user presses enter to pick a search result.</returns>
    public extern VirtualKeyModifiers KeyModifiers { [MethodImpl] get; }
  }
}
