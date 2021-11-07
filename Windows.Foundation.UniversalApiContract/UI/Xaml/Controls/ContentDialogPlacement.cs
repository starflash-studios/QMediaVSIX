// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentDialogPlacement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify where in the XAML visual tree a ContentDialog is rooted.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum ContentDialogPlacement
  {
    /// <summary>The dialog is rooted in the PopupRoot element of the XAML Window.</summary>
    Popup,
    /// <summary>If the dialog has a parent element, the dialog is rooted in the parent's visual tree. Otherwise, it falls back to the **Popup** behavior.</summary>
    InPlace,
  }
}
