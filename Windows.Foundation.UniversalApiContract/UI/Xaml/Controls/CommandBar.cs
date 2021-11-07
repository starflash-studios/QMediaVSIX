// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CommandBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a specialized app bar that provides layout for AppBarButton and related command elements.</summary>
  [ContentProperty(Name = "PrimaryCommands")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ICommandBarFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICommandBarStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (ICommandBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICommandBarStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class CommandBar : AppBar, ICommandBar, ICommandBar2, ICommandBar3
  {
    /// <summary>Initializes a new instance of the CommandBar class.</summary>
    [MethodImpl]
    public extern CommandBar();

    /// <summary>Gets the collection of primary command elements for the CommandBar.</summary>
    /// <returns>The collection of primary command elements for the CommandBar. The default is an empty collection.</returns>
    public extern IObservableVector<ICommandBarElement> PrimaryCommands { [MethodImpl] get; }

    /// <summary>Gets the collection of secondary command elements for the CommandBar.</summary>
    /// <returns>The collection of secondary command elements for the CommandBar. The default is an empty collection.</returns>
    public extern IObservableVector<ICommandBarElement> SecondaryCommands { [MethodImpl] get; }

    /// <summary>Gets or sets the Style applied to the overflow content of the CommandBar.</summary>
    /// <returns>The applied Style for the overflow content of the CommandBar, if present; otherwise, **null**. The default is **null**.</returns>
    public extern Style CommandBarOverflowPresenterStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as {TemplateBinding} markup extension sources when defining templates for a CommandBar control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern CommandBarTemplateSettings CommandBarTemplateSettings { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the placement and visibility of the labels on the command bar's buttons.</summary>
    /// <returns>An enumeration value that indicates the placement and visibility of the labels on the command bar's buttons. The default is **Bottom**.</returns>
    public extern CommandBarDefaultLabelPosition DefaultLabelPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates when a command bar's overflow button is shown.</summary>
    /// <returns>An enumeration value that indicates when a command bar's overflow button is shown. The default is **Auto**.</returns>
    public extern CommandBarOverflowButtonVisibility OverflowButtonVisibility { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether primary commands automatically move to the overflow menu when space is limited.</summary>
    /// <returns>**true** if primary commands automatically move to the overflow menu when space is limited; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsDynamicOverflowEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when items move into or out of the overflow menu.</summary>
    public extern event TypedEventHandler<CommandBar, DynamicOverflowItemsChangingEventArgs> DynamicOverflowItemsChanging;

    /// <summary>Identifies the DefaultLabelPosition dependency property.</summary>
    /// <returns>The identifier for the DefaultLabelPosition dependency property.</returns>
    public static extern DependencyProperty DefaultLabelPositionProperty { [MethodImpl] get; }

    /// <summary>Identifies the OverflowButtonVisibility dependency property.</summary>
    /// <returns>The identifier for the OverflowButtonVisibility dependency property.</returns>
    public static extern DependencyProperty OverflowButtonVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsDynamicOverflowEnabled dependency property.</summary>
    /// <returns>The identifier for the IsDynamicOverflowEnabled dependency property.</returns>
    public static extern DependencyProperty IsDynamicOverflowEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the CommandBarOverflowPresenterStyle dependency property.</summary>
    /// <returns>The identifier for the CommandBarOverflowPresenterStyle dependency property.</returns>
    public static extern DependencyProperty CommandBarOverflowPresenterStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the PrimaryCommands dependency property.</summary>
    /// <returns>The identifier for the PrimaryCommands dependency property.</returns>
    public static extern DependencyProperty PrimaryCommandsProperty { [MethodImpl] get; }

    /// <summary>Identifies the SecondaryCommands dependency property.</summary>
    /// <returns>The identifier for the SecondaryCommands dependency property.</returns>
    public static extern DependencyProperty SecondaryCommandsProperty { [MethodImpl] get; }
  }
}
