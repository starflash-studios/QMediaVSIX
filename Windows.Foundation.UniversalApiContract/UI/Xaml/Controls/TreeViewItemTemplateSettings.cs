// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TreeViewItemTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a TreeViewItem control. Not intended for general use.</summary>
  [Composable(typeof (ITreeViewItemTemplateSettingsFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITreeViewItemTemplateSettingsStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public class TreeViewItemTemplateSettings : DependencyObject, ITreeViewItemTemplateSettings
  {
    /// <summary>Initializes a new instance of the TreeViewItemTemplateSettings class.</summary>
    [MethodImpl]
    public extern TreeViewItemTemplateSettings();

    /// <summary>Gets the visibilty of an expanded glyph.</summary>
    /// <returns>The visibilty of an expanded glyph.</returns>
    public extern Visibility ExpandedGlyphVisibility { [MethodImpl] get; }

    /// <summary>Gets the visibilty of a collapsed glyph.</summary>
    /// <returns>The visibilty of a collapsed glyph.</returns>
    public extern Visibility CollapsedGlyphVisibility { [MethodImpl] get; }

    /// <summary>Gets the amount that the item is indented.</summary>
    /// <returns>The amount that the item is indented.</returns>
    public extern Thickness Indentation { [MethodImpl] get; }

    /// <summary>Gets the number of items being dragged.</summary>
    /// <returns>The number of items being dragged.</returns>
    public extern int DragItemsCount { [MethodImpl] get; }

    /// <summary>Identifies the ExpandedGlyphVisibility dependency property.</summary>
    /// <returns>The identifier for the ExpandedGlyphVisibility dependency property.</returns>
    public static extern DependencyProperty ExpandedGlyphVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the CollapsedGlyphVisibility dependency property.</summary>
    /// <returns>The identifier for the CollapsedGlyphVisibility dependency property.</returns>
    public static extern DependencyProperty CollapsedGlyphVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the Indentation dependency property.</summary>
    /// <returns>The identifier for the Indentation dependency property.</returns>
    public static extern DependencyProperty IndentationProperty { [MethodImpl] get; }

    /// <summary>Identifies the DragItemsCount dependency property.</summary>
    /// <returns>The identifier for the DragItemsCount dependency property.</returns>
    public static extern DependencyProperty DragItemsCountProperty { [MethodImpl] get; }
  }
}
