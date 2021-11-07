// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify what action causes a SelectionChanged event to occur.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum ComboBoxSelectionChangedTrigger
  {
    /// <summary>A change event occurs when the user commits a selection in the combo box.</summary>
    Committed,
    /// <summary>A change event occurs each time the user navigates to a new selection in the combo box.</summary>
    Always,
  }
}
