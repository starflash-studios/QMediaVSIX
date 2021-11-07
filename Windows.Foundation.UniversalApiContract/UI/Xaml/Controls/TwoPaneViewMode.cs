// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TwoPaneViewMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how panes are shown in a TwoPaneView.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum TwoPaneViewMode
  {
    /// <summary>Only one pane is shown.</summary>
    SinglePane,
    /// <summary>Panes are shown side-by-side.</summary>
    Wide,
    /// <summary>Panes are shown top-bottom.</summary>
    Tall,
  }
}
