// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.LoopingSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>An infinitely scrolling selection control.</summary>
  [Static(typeof (ILoopingSelectorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class LoopingSelector : Control, ILoopingSelector
  {
    /// <summary>Gets or sets a value that determines whether the LoopingSelector loops indefinitely.</summary>
    /// <returns>**True** if the LoopingSelector loops through all LoopingSelectorItem items indefinitely; otherwise, **false**.</returns>
    public extern bool ShouldLoop { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of the LoopingSelectorItem objects.</summary>
    /// <returns>The list of LoopingSelectorItem objects.</returns>
    public extern IVector<object> Items { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the index of the LoopingSelectorItem that is displayed in the LoopingSelector.</summary>
    /// <returns>The index of the LoopingSelectorItem that is visible in the LoopingSelector.</returns>
    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the LoopingSelectorItem that is displayed in the LoopingSelector.</summary>
    /// <returns>The LoopingSelectorItem that is visible in the LoopingSelector.</returns>
    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of a LoopingSelectorItem that is contained in a LoopingSelector.</summary>
    /// <returns>The width of the layout area for the LoopingSelectorItem that is contained in the LoopingSelector.</returns>
    public extern int ItemWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height of a LoopingSelectorItem that is contained in a LoopingSelector.</summary>
    /// <returns>The height of the layout area for the LoopingSelectorItem that is contained in the LoopingSelector.</returns>
    public extern int ItemHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display each LoopingSelectorItem.</summary>
    /// <returns>The template that specifies the visualization of the LoopingSelectorItem items.</returns>
    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the currently selected item changes.</summary>
    public extern event SelectionChangedEventHandler SelectionChanged;

    /// <summary>Identifies the ShouldLoop dependency property.</summary>
    /// <returns>The identifier for the ShouldLoop dependency property.</returns>
    public static extern DependencyProperty ShouldLoopProperty { [MethodImpl] get; }

    /// <summary>Identifies the Items dependency property.</summary>
    /// <returns>The identifier for the Items dependency property.</returns>
    public static extern DependencyProperty ItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedIndex dependency property.</summary>
    /// <returns>The identifier for the SelectedIndex dependency property.</returns>
    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedItem dependency property.</summary>
    /// <returns>The identifier for the SelectedItem dependency property.</returns>
    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemWidth dependency property.</summary>
    /// <returns>The identifier for the ItemWidth dependency property.</returns>
    public static extern DependencyProperty ItemWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemHeight dependency property.</summary>
    /// <returns>The identifier for the ItemHeight dependency property.</returns>
    public static extern DependencyProperty ItemHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemTemplate dependency property.</summary>
    /// <returns>The identifier for the ItemTemplate dependency property.</returns>
    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }
  }
}
