// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the AutoSuggestBox.QuerySubmitted event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class AutoSuggestBoxQuerySubmittedEventArgs : 
    DependencyObject,
    IAutoSuggestBoxQuerySubmittedEventArgs
  {
    /// <summary>Initializes a new instance of the AutoSuggestBoxQuerySubmittedEventArgs class.</summary>
    [MethodImpl]
    public extern AutoSuggestBoxQuerySubmittedEventArgs();

    /// <summary>Gets the query text of the current search.</summary>
    /// <returns>The query text of the current search.</returns>
    public extern string QueryText { [MethodImpl] get; }

    /// <summary>Gets the suggested result that the user chose.</summary>
    /// <returns>The suggested result that the user chose.</returns>
    public extern object ChosenSuggestion { [MethodImpl] get; }
  }
}
