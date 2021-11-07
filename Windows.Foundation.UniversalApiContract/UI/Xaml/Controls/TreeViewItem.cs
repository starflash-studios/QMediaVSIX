// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TreeViewItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the container for an item in a TreeView control.</summary>
  [Static(typeof (ITreeViewItemStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ITreeViewItemFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITreeViewItemStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class TreeViewItem : ListViewItem, ITreeViewItem, ITreeViewItem2
  {
    /// <summary>Initializes a new instance of the TreeViewItem control.</summary>
    [MethodImpl]
    public extern TreeViewItem();

    /// <summary>Gets or sets the opacity of node glyphs on a TreeView.</summary>
    /// <returns>The opacity of node glyphs on a TreeView.</returns>
    public extern double GlyphOpacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush used to paint node glyphs on a TreeView.</summary>
    /// <returns>The Brush used to paint node glyphs on a TreeView.</returns>
    public extern Brush GlyphBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the glyph to show for an expanded tree node.</summary>
    /// <returns>The glyph to show for an expanded tree node.</returns>
    public extern string ExpandedGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the glyph to show for a collapsed tree node.</summary>
    /// <returns>The glyph to show for a collapsed tree node.</returns>
    public extern string CollapsedGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the size of node glyphs on a TreeView.</summary>
    /// <returns>The opacity of size glyphs on a TreeView.</returns>
    public extern double GlyphSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a tree node is expanded.</summary>
    /// <returns>**true** if the tree node is expanded; otherwise, **false**.</returns>
    public extern bool IsExpanded { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as {TemplateBinding} markup extension sources when defining templates for a TreeViewItem control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern TreeViewItemTemplateSettings TreeViewItemTemplateSettings { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the current item has child items that haven't been shown.</summary>
    /// <returns>**true** of the current item has child items that haven't been shown; otherwise, **false**.</returns>
    public extern bool HasUnrealizedChildren { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object source used to generate the content of the TreeView.</summary>
    /// <returns>The object that is used to generate the content of the TreeViewItem. The default is **null**.</returns>
    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the HasUnrealizedChildren dependency property.</summary>
    /// <returns>The identifier for the HasUnrealizedChildren dependency property.</returns>
    public static extern DependencyProperty HasUnrealizedChildrenProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemsSource dependency property.</summary>
    /// <returns>The identifier for the ItemsSource dependency property.</returns>
    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the GlyphOpacity dependency property.</summary>
    /// <returns>The identifier for the GlyphOpacity dependency property.</returns>
    public static extern DependencyProperty GlyphOpacityProperty { [MethodImpl] get; }

    /// <summary>Identifies the GlyphBrush dependency property.</summary>
    /// <returns>The identifier for the GlyphBrush dependency property.</returns>
    public static extern DependencyProperty GlyphBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the ExpandedGlyph dependency property.</summary>
    /// <returns>The identifier for the ExpandedGlyph dependency property.</returns>
    public static extern DependencyProperty ExpandedGlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the CollapsedGlyph dependency property.</summary>
    /// <returns>The identifier for the CollapsedGlyph dependency property.</returns>
    public static extern DependencyProperty CollapsedGlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the GlyphSize dependency property.</summary>
    /// <returns>The identifier for the GlyphSize dependency property.</returns>
    public static extern DependencyProperty GlyphSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsExpanded dependency property.</summary>
    /// <returns>The identifier for the IsExpanded dependency property.</returns>
    public static extern DependencyProperty IsExpandedProperty { [MethodImpl] get; }

    /// <summary>Identifies the TreeViewItemTemplateSettings dependency property.</summary>
    /// <returns>The identifier for the TreeViewItemTemplateSettings dependency property.</returns>
    public static extern DependencyProperty TreeViewItemTemplateSettingsProperty { [MethodImpl] get; }
  }
}
