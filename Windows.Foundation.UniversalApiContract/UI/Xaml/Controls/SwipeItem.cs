// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwipeItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an individual command in a SwipeControl.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (ISwipeItemStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ISwipeItemFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class SwipeItem : DependencyObject, ISwipeItem
  {
    /// <summary>Initializes a new instance of the SwipeItem class.</summary>
    [MethodImpl]
    public extern SwipeItem();

    /// <summary>Gets or sets the text description displayed on the item.</summary>
    /// <returns>The text description displayed on the item. The default is an empty string.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the graphic content of the item.</summary>
    /// <returns>The graphic content of the item. The default is **null**.</returns>
    public extern IconSource IconSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the background of the control.</summary>
    /// <returns>The brush that provides the background of the control.</returns>
    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush that paints the text and icon of the item.</summary>
    /// <returns>The brush that paints the text and icon of the item.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command to execute when this item is invoked.</summary>
    /// <returns>The command to execute when this item is invoked. The default is **null**.</returns>
    public extern ICommand Command { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameter to pass to the Command property.</summary>
    /// <returns>The parameter to pass to the Command property. The default is **null**.</returns>
    public extern object CommandParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how a SwipeControl behaves after this item is invoked.</summary>
    /// <returns>A value that indicates how a SwipeControl behaves after this item is invoked. The default is **Auto**.</returns>
    public extern SwipeBehaviorOnInvoked BehaviorOnInvoked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when user interaction indicates that the command represented by this item should execute.</summary>
    public extern event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> Invoked;

    /// <summary>Identifies the IconSource dependency property.</summary>
    /// <returns>The identifier for the IconSource dependency property.</returns>
    public static extern DependencyProperty IconSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the Text dependency property.</summary>
    /// <returns>The identifier for the Text dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    /// <summary>Identifies the Background dependency property.</summary>
    /// <returns>The identifier for the Background dependency property.</returns>
    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the Foreground dependency property.</summary>
    /// <returns>The identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the Command dependency property.</summary>
    /// <returns>The identifier for the Command dependency property.</returns>
    public static extern DependencyProperty CommandProperty { [MethodImpl] get; }

    /// <summary>Identifies the CommandParameter dependency property.</summary>
    /// <returns>The identifier for the CommandParameter dependency property.</returns>
    public static extern DependencyProperty CommandParameterProperty { [MethodImpl] get; }

    /// <summary>Identifies the BehaviorOnInvoked dependency property.</summary>
    /// <returns>The identifier for the BehaviorOnInvoked dependency property.</returns>
    public static extern DependencyProperty BehaviorOnInvokedProperty { [MethodImpl] get; }
  }
}
