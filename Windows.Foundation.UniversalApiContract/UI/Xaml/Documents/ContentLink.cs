// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ContentLink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Provides an inline-level content element that provides facilities for hosting links to contextual information.</summary>
  [Static(typeof (IContentLinkStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ContentLink : Inline, IContentLink
  {
    /// <summary>Initializes a new instance of the ContentLink class.</summary>
    [MethodImpl]
    public extern ContentLink();

    /// <summary>Gets or sets the information that the ContentLink contains.</summary>
    /// <returns>The information that the ContentLink contains.</returns>
    public extern ContentLinkInfo Info { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the background color of the link.</summary>
    /// <returns>The brush that provides the background color of the link.</returns>
    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of cursor to show when the pointer is over the link.</summary>
    /// <returns>The type of cursor to show when the pointer is over the link.</returns>
    public extern CoreCursorType Cursor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) left.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD) left.</returns>
    public extern DependencyObject XYFocusLeft { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) right.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD) right.</returns>
    public extern DependencyObject XYFocusRight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) up.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD) up.</returns>
    public extern DependencyObject XYFocusUp { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) down.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD) down.</returns>
    public extern DependencyObject XYFocusDown { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the control's preference for whether it plays sounds.</summary>
    /// <returns>An enumeration value that specifies the control's preference for whether it plays sounds. The default is **Default**.</returns>
    public extern ElementSoundMode ElementSoundMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies whether this link has focus, and the mode by which focus was obtained.</summary>
    /// <returns>A value of the enumeration. A value of **Unfocused** indicates that the link does not have focus.</returns>
    public extern FocusState FocusState { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of an up navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusUpNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of a down navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusDownNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of a left navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of a right navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusRightNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the link is included in tab navigation.</summary>
    /// <returns>**true** if the control is included in tab navigation; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTabStop { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines the order in which elements receive focus when the user navigates through controls by pressing the Tab key.</summary>
    /// <returns>A value that determines the order of logical navigation for a device. The default value is MaxValue.</returns>
    public extern int TabIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when user interaction activates the link.</summary>
    public extern event TypedEventHandler<ContentLink, ContentLinkInvokedEventArgs> Invoked;

    /// <summary>Occurs when a link receives focus.</summary>
    public extern event RoutedEventHandler GotFocus;

    /// <summary>Occurs when a link loses focus.</summary>
    public extern event RoutedEventHandler LostFocus;

    /// <summary>Attempts to set the focus on the link.</summary>
    /// <param name="value">Specifies how focus was set, as a value of the enumeration.</param>
    /// <returns>**true** if focus was set to the link, or focus was already on the link. **false** if the link is not focusable.</returns>
    [MethodImpl]
    public extern bool Focus(FocusState value);

    /// <summary>Identifies the Background dependency property.</summary>
    /// <returns>The identifier for the Background dependency property.</returns>
    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the Cursor dependency property.</summary>
    /// <returns>The identifier for the Cursor dependency property.</returns>
    public static extern DependencyProperty CursorProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusLeft dependency property.</summary>
    /// <returns>The identifier for the XYFocusLeft dependency property.</returns>
    public static extern DependencyProperty XYFocusLeftProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusRight dependency property.</summary>
    /// <returns>The identifier for the XYFocusRight dependency property.</returns>
    public static extern DependencyProperty XYFocusRightProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusUp dependency property.</summary>
    /// <returns>The identifier for the XYFocusUp dependency property.</returns>
    public static extern DependencyProperty XYFocusUpProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusDown dependency property.</summary>
    /// <returns>The identifier for the XYFocusDown dependency property.</returns>
    public static extern DependencyProperty XYFocusDownProperty { [MethodImpl] get; }

    /// <summary>Identifies the ElementSoundMode dependency property.</summary>
    /// <returns>The identifier for the ElementSoundMode dependency property.</returns>
    public static extern DependencyProperty ElementSoundModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusState dependency property.</summary>
    /// <returns>The identifier for the FocusState dependency property.</returns>
    public static extern DependencyProperty FocusStateProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusUpNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusUpNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusUpNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusDownNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusDownNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusDownNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusLeftNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusLeftNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusLeftNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusRightNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusRightNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusRightNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTabStop dependency property.</summary>
    /// <returns>The identifier for the IsTabStop dependency property.</returns>
    public static extern DependencyProperty IsTabStopProperty { [MethodImpl] get; }

    /// <summary>Identifies the TabIndex dependency property.</summary>
    /// <returns>The identifier for the TabIndex dependency property.</returns>
    public static extern DependencyProperty TabIndexProperty { [MethodImpl] get; }
  }
}
