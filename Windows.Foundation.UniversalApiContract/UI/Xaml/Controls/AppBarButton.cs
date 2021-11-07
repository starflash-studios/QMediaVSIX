// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AppBarButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a templated button control to be displayed in an AppBar.</summary>
  [Composable(typeof (IAppBarButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppBarButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppBarButtonStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAppBarButtonStatics4), 393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class AppBarButton : 
    Button,
    IAppBarButton,
    IAppBarButton3,
    IAppBarButton4,
    IAppBarButton5,
    ICommandBarElement,
    ICommandBarElement2
  {
    /// <summary>Initializes a new instance of the AppBarButton class.</summary>
    [MethodImpl]
    public extern AppBarButton();

    /// <summary>Gets or sets the text description displayed on the app bar button.</summary>
    /// <returns>The text description displayed on the app bar button.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the graphic content of the app bar button.</summary>
    /// <returns>The graphic content of the app bar button.</returns>
    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the placement and visibility of the button's label.</summary>
    /// <returns>An enumeration value that specifies the placement and visibility of the button's label. The default is **Default**.</returns>
    public extern CommandBarLabelPosition LabelPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that overrides the default key combination string associated with a keyboard accelerator.</summary>
    /// <returns>The string to replace the default key combination string. The default is null.</returns>
    public extern string KeyboardAcceleratorTextOverride { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as {TemplateBinding} markup extension sources when defining templates for an AppBarButton control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern AppBarButtonTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the button is shown with no label and reduced padding.</summary>
    /// <returns>**true** if the button is shown in its compact state; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsCompact { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether this item is in the overflow menu.</summary>
    /// <returns>**true** if this item is in the overflow menu; otherwise, **false**.</returns>
    public extern bool IsInOverflow { [MethodImpl] get; }

    /// <summary>Gets or sets the order in which this item is moved to the CommandBar overflow menu.</summary>
    /// <returns>The order in which this item is moved to the overflow menu relative to other items.</returns>
    public extern int DynamicOverflowOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the AppBarButton.KeyboardAcceleratorTextOverride dependency property.</summary>
    /// <returns>The identifier for the AppBarButton.KeyboardAcceleratorTextOverride dependency property.</returns>
    public static extern DependencyProperty KeyboardAcceleratorTextOverrideProperty { [MethodImpl] get; }

    /// <summary>Identifies the LabelPosition dependency property.</summary>
    /// <returns>The identifier for the LabelPosition dependency property.</returns>
    public static extern DependencyProperty LabelPositionProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsInOverflow dependency property.</summary>
    /// <returns>The identifier for the IsInOverflow dependency property.</returns>
    public static extern DependencyProperty IsInOverflowProperty { [MethodImpl] get; }

    /// <summary>Identifies the DynamicOverflowOrder dependency property.</summary>
    /// <returns>The identifier for the DynamicOverflowOrder dependency property.</returns>
    public static extern DependencyProperty DynamicOverflowOrderProperty { [MethodImpl] get; }

    /// <summary>Identifies the Label dependency property.</summary>
    /// <returns>The identifier for the Label dependency property.</returns>
    public static extern DependencyProperty LabelProperty { [MethodImpl] get; }

    /// <summary>Identifies the Icon dependency property.</summary>
    /// <returns>The identifier for the Icon dependency property.</returns>
    public static extern DependencyProperty IconProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsCompact dependency property.</summary>
    /// <returns>The identifier for the IsCompact dependency property.</returns>
    public static extern DependencyProperty IsCompactProperty { [MethodImpl] get; }
  }
}
