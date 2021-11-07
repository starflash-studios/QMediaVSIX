// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the TextChanged event.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAutoSuggestBoxTextChangedEventArgsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AutoSuggestBoxTextChangedEventArgs : 
    DependencyObject,
    IAutoSuggestBoxTextChangedEventArgs
  {
    /// <summary>Initializes a new instance of the AutoSuggestBoxTextChangedEventArgs class.</summary>
    [MethodImpl]
    public extern AutoSuggestBoxTextChangedEventArgs();

    /// <summary>Gets or sets a value that indicates the reason for the text changing in the AutoSuggestBox.</summary>
    /// <returns>The reason for the text changing in the AutoSuggestBox.</returns>
    public extern AutoSuggestionBoxTextChangeReason Reason { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a Boolean value indicating if the current value of the TextBox is unchanged from the point in time when the TextChanged event was raised.</summary>
    /// <returns>Indicates if the current value of the TextBox is unchanged from the point in time when the TextChanged event was raised.</returns>
    [MethodImpl]
    public extern bool CheckCurrent();

    /// <summary>Identifies the Reason dependency property.</summary>
    /// <returns>Identifier for the Reason dependency property.</returns>
    public static extern DependencyProperty ReasonProperty { [MethodImpl] get; }
  }
}
