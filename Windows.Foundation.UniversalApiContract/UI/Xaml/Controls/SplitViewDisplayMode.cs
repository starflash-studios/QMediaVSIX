// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SplitViewDisplayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how the pane is shown in a SplitView.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum SplitViewDisplayMode
  {
    /// <summary>The pane covers the content when it's open and does not take up space in the control layout. The pane closes when the user taps outside of it.</summary>
    Overlay,
    /// <summary>The pane is shown side-by-side with the content and takes up space in the control layout. The pane does not close when the user taps outside of it.</summary>
    Inline,
    /// <summary>The amount of the pane defined by the CompactPaneLength property is shown side-by-side with the content and takes up space in the control layout. The remaining part of the pane covers the content when it's open and does not take up space in the control layout. The pane closes when the user taps outside of it.</summary>
    CompactOverlay,
    /// <summary>The amount of the pane defined by the CompactPaneLength property is shown side-by-side with the content and takes up space in the control layout. The remaining part of the pane pushes the content to the side when it's open and takes up space in the control layout. The pane does not close when the user taps outside of it.</summary>
    CompactInline,
  }
}
