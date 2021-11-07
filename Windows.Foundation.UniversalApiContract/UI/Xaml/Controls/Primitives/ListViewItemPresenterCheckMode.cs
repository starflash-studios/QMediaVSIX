// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenterCheckMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify the style of checkbox shown to select an item.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ListViewItemPresenterCheckMode
  {
    /// <summary>The checkbox in shown inline with the content of the list item.</summary>
    Inline,
    /// <summary>The checkbox is shown over the content of the list item.</summary>
    Overlay,
  }
}
