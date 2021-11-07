// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a NavigationView. Not intended for general use.</summary>
  [WebHostHidden]
  [Composable(typeof (INavigationViewTemplateSettingsFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (INavigationViewTemplateSettingsStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public class NavigationViewTemplateSettings : DependencyObject, INavigationViewTemplateSettings
  {
    /// <summary>Initializes a new instance of the NavigationViewTemplateSettings class.</summary>
    [MethodImpl]
    public extern NavigationViewTemplateSettings();

    /// <summary>Gets the padding value of the top pane.</summary>
    /// <returns>The padding value of the top pane.</returns>
    public extern double TopPadding { [MethodImpl] get; }

    /// <summary>Gets the visibility of the overflow button.</summary>
    /// <returns>The visibility of the overflow button.</returns>
    public extern Visibility OverflowButtonVisibility { [MethodImpl] get; }

    /// <summary>Gets the visibility of the pane toggle button.</summary>
    /// <returns>The visibility of the pane toggle button.</returns>
    public extern Visibility PaneToggleButtonVisibility { [MethodImpl] get; }

    /// <summary>Gets the visibility of the back button.</summary>
    /// <returns>The visibility of the back button.</returns>
    public extern Visibility BackButtonVisibility { [MethodImpl] get; }

    /// <summary>Gets the visibility of the top pane.</summary>
    /// <returns>The visibility of the top pane.</returns>
    public extern Visibility TopPaneVisibility { [MethodImpl] get; }

    /// <summary>Gets the visibility of the left pane.</summary>
    /// <returns>The visibility of the left pane.</returns>
    public extern Visibility LeftPaneVisibility { [MethodImpl] get; }

    /// <summary>Gets the SelectionFollowsFocus value.</summary>
    /// <returns>The SelectionFollowsFocus value.</returns>
    public extern bool SingleSelectionFollowsFocus { [MethodImpl] get; }

    /// <summary>Identifies the TopPadding dependency property.</summary>
    /// <returns>The identifier for the TopPadding dependency property.</returns>
    public static extern DependencyProperty TopPaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the OverflowButtonVisibility dependency property.</summary>
    /// <returns>The identifier for the OverflowButtonVisibility dependency property.</returns>
    public static extern DependencyProperty OverflowButtonVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the PaneToggleButtonVisibility dependency property.</summary>
    /// <returns>The identifier for the PaneToggleButtonVisibility dependency property.</returns>
    public static extern DependencyProperty PaneToggleButtonVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the BackButtonVisibility dependency property.</summary>
    /// <returns>The identifier for the BackButtonVisibility dependency property.</returns>
    public static extern DependencyProperty BackButtonVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the TopPaneVisibility dependency property.</summary>
    /// <returns>The identifier for the TopPaneVisibility dependency property.</returns>
    public static extern DependencyProperty TopPaneVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the LeftPaneVisibility dependency property.</summary>
    /// <returns>The identifier for the LeftPaneVisibility dependency property.</returns>
    public static extern DependencyProperty LeftPaneVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the SingleSelectionFollowsFocus dependency property.</summary>
    /// <returns>The identifier for the SingleSelectionFollowsFocus dependency property.</returns>
    public static extern DependencyProperty SingleSelectionFollowsFocusProperty { [MethodImpl] get; }
  }
}
