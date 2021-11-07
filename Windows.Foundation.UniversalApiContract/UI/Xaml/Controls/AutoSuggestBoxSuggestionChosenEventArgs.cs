// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the SuggestionChosen event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class AutoSuggestBoxSuggestionChosenEventArgs : 
    DependencyObject,
    IAutoSuggestBoxSuggestionChosenEventArgs
  {
    /// <summary>Initializes a new instance of the AutoSuggestBoxSuggestionChosenEventArgs class.</summary>
    [MethodImpl]
    public extern AutoSuggestBoxSuggestionChosenEventArgs();

    /// <summary>Gets a reference to the selected item.</summary>
    /// <returns>A reference to the selected item.</returns>
    public extern object SelectedItem { [MethodImpl] get; }
  }
}
