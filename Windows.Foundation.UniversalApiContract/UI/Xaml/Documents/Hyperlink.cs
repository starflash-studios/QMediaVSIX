// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Hyperlink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Provides an inline-level content element that provides facilities for hosting hyperlinks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IHyperlinkStatics5), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHyperlinkStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHyperlinkStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHyperlinkStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHyperlinkStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class Hyperlink : 
    Span,
    IHyperlink,
    IHyperlink2,
    IHyperlink3,
    IHyperlink4,
    IHyperlink5
  {
    /// <summary>Initializes a new instance of the Hyperlink class.</summary>
    [MethodImpl]
    public extern Hyperlink();

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) to navigate to when the Hyperlink is activated.</summary>
    /// <returns>The Uniform Resource Identifier (URI) to navigate to when the Hyperlink is activated. The default is **null**.</returns>
    public extern Uri NavigateUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Hyperlink is clicked.</summary>
    public extern event TypedEventHandler<Hyperlink, HyperlinkClickEventArgs> Click;

    /// <summary>Gets or sets a value that indicates what kind of underline is shown under the hyperlink.</summary>
    /// <returns>An enumeration value that specifies what kind of underline is shown. The default is **Single**.</returns>
    public extern UnderlineStyle UnderlineStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) left.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD).</returns>
    public extern DependencyObject XYFocusLeft { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) right.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD).</returns>
    public extern DependencyObject XYFocusRight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) up.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD).</returns>
    public extern DependencyObject XYFocusUp { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (DPAD) down.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (DPAD).</returns>
    public extern DependencyObject XYFocusDown { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the control's preference for whether it plays sounds.</summary>
    /// <returns>An enumeration value that specifies the control's preference for whether it plays sounds. The default is **Default**.</returns>
    public extern ElementSoundMode ElementSoundMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies whether this hyperlink has focus, and the mode by which focus was obtained.</summary>
    /// <returns>A value of the enumeration. A value of **Unfocused** indicates that the hyperlink does not have focus.</returns>
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

    /// <summary>Occurs when a **Hyperlink** receives focus.</summary>
    public extern event RoutedEventHandler GotFocus;

    /// <summary>Occurs when a **Hyperlink** loses focus.</summary>
    public extern event RoutedEventHandler LostFocus;

    /// <summary>Attempts to set the focus on the hyperlink.</summary>
    /// <param name="value">Specifies how focus was set, as a value of the enumeration.</param>
    /// <returns>**true** if focus was set to the hyperlink, or focus was already on the hyperlink. **false** if the hyperlink is not focusable.</returns>
    [MethodImpl]
    public extern bool Focus(FocusState value);

    /// <summary>Gets or sets a value that indicates whether the hyperlink is included in tab navigation.</summary>
    /// <returns>**true** if the control is included in tab navigation; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTabStop { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines the order in which elements receive focus when the user navigates through controls by pressing the Tab key.</summary>
    /// <returns>A value that determines the order of logical navigation for a device. The default value is MaxValue.</returns>
    public extern int TabIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsTabStop dependency property.</summary>
    /// <returns>The identifier for the IsTabStop dependency property.</returns>
    public static extern DependencyProperty IsTabStopProperty { [MethodImpl] get; }

    /// <summary>Identifies the TabIndex dependency property.</summary>
    /// <returns>The identifier for the TabIndex dependency property.</returns>
    public static extern DependencyProperty TabIndexProperty { [MethodImpl] get; }

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

    /// <summary>Identifies the UnderlineStyle dependency property.</summary>
    /// <returns>The identifier for the UnderlineStyle dependency property.</returns>
    public static extern DependencyProperty UnderlineStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the NavigateUri dependency property.</summary>
    /// <returns>The identifier for the NavigateUri dependency property.</returns>
    public static extern DependencyProperty NavigateUriProperty { [MethodImpl] get; }
  }
}
