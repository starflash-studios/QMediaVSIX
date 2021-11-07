// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewDisplayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how the pane is shown in a NavigationView.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum NavigationViewDisplayMode
  {
    /// <summary>Only the menu button remains fixed. The pane shows and hides as needed.</summary>
    Minimal,
    /// <summary>The pane always shows as a narrow sliver which can be opened to full width.</summary>
    Compact,
    /// <summary>The pane stays open alongside the content.</summary>
    Expanded,
  }
}
