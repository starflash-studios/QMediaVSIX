// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewPaneDisplayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how and where the NavigationView pane is shown.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum NavigationViewPaneDisplayMode
  {
    /// <summary>The pane is shown on the left side of the control, and changes between minimal, compact, and full states depending on the width of the window.</summary>
    Auto,
    /// <summary>The pane is shown on the left side of the control in its fully open state.</summary>
    Left,
    /// <summary>The pane is shown at the top of the control.</summary>
    Top,
    /// <summary>The pane is shown on the left side of the control. Only the pane icons are shown by default.</summary>
    LeftCompact,
    /// <summary>The pane is shown on the left side of the control. Only the pane menu button is shown by default.</summary>
    LeftMinimal,
  }
}
