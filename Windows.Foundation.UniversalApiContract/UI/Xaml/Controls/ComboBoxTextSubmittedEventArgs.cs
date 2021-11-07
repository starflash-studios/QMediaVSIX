// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ComboBoxTextSubmittedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data when the user enters custom text into the ComboBox.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class ComboBoxTextSubmittedEventArgs : IComboBoxTextSubmittedEventArgs
  {
    /// <summary>Gets the custom text value entered by the user.</summary>
    /// <returns>
    /// </returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Gets or sets whether the TextSubmitted event was handled or not. If **true**, the framework will not automatically update the selected item of the ComboBox to the new value.</summary>
    /// <returns>
    /// </returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
