// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.TextElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>An abstract class used as the base class for the also-abstract Block and Inline classes. TextElement supports common API for classes involved in the XAML text object model, such as properties that control text size, font families and so on.</summary>
  [Static(typeof (ITextElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextElementStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITextElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ITextElementFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextElementStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  public class TextElement : 
    DependencyObject,
    ITextElement,
    ITextElement2,
    ITextElement3,
    ITextElement4,
    ITextElement5,
    ITextElementOverrides
  {
    /// <summary>Gets or sets a unique identification for the object. Name can only be set from initial parsing of XAML.</summary>
    /// <returns>The unique identifier for the object. This property is read-only for code, but write-only for XAML, due to special parser handling of XAML properties named "Name".</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets or sets the font size for the content of the element.</summary>
    /// <returns>The desired font size in pixels. The default is 11 pixels.</returns>
    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the preferred top-level font family for the content of the element.</summary>
    /// <returns>The preferred font family, or a primary preferred font family with one or more fallback font families. See FontFamily for default information.</returns>
    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the top-level font weight to select from the font family for the content in this element.</summary>
    /// <returns>One of the FontWeights property values, specifying the font weight. The default is Normal.</returns>
    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style for the content in this element.</summary>
    /// <returns>One of the FontStyle constant names, specifying the font style. The default is **Normal**.</returns>
    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the glyph width of the font in a family to select.</summary>
    /// <returns>One of the FontStretch constant names, specifying the desired font stretch. The default is **Normal**.</returns>
    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the uniform spacing between characters, in units of 1/1000 of an em.</summary>
    /// <returns>The uniform spacing between characters, in units of 1/1000 of an em. The default is 0. Positive values increase tracking and loosen character spacing. Negative values decrease tracking and tighten the character spacing.</returns>
    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush to apply to the content in this element.</summary>
    /// <returns>The brush that is applied to the text content. The default is a SolidColorBrush with Color value Black.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets localization/globalization language information that applies to a TextElement.</summary>
    /// <returns>A string specifying language and culture that follows the RFC 3066 / ISO 639-1 standards. For example, U.S. English is "en-US".</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a TextPointer that represents the start of content in the element.</summary>
    /// <returns>A TextPointer that represents the start of the content in the TextElement.</returns>
    public extern TextPointer ContentStart { [MethodImpl] get; }

    /// <summary>Gets a TextPointer that represents the end of the content in the element.</summary>
    /// <returns>A TextPointer that represents the end of the content in the TextElement.</returns>
    public extern TextPointer ContentEnd { [MethodImpl] get; }

    /// <summary>Gets a TextPointer that represents the position just before the start of the element.</summary>
    /// <returns>A TextPointer that represents the position just before the start of the TextElement.</returns>
    public extern TextPointer ElementStart { [MethodImpl] get; }

    /// <summary>Gets a TextPointer that represents the position just after the end of the element.</summary>
    /// <returns>A TextPointer that represents the position just after the end of the TextElement.</returns>
    public extern TextPointer ElementEnd { [MethodImpl] get; }

    /// <summary>Retrieves an object in the object model / runtime object graph by referencing the object's **x:Name** or **Name** attribute value.</summary>
    /// <param name="name">The name of the object to retrieve.</param>
    /// <returns>The object that has the specified name, or null if no object is retrieved.</returns>
    [MethodImpl]
    public extern object FindName(string name);

    /// <summary>Gets or sets whether automatic text enlargement, to reflect the system text size setting, is enabled.</summary>
    /// <returns>**true** if automatic text enlargement is enabled; otherwise, **false**.</returns>
    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the element automatically gets focus when the user interacts with it.</summary>
    /// <returns>**true** if the element gets focus when a user interacts with it; otherwise, **false**.</returns>
    public extern bool AllowFocusOnInteraction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the access key for this element.</summary>
    /// <returns>The access key for this element.</returns>
    public extern string AccessKey { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the access key display is dismissed when an access key is invoked.</summary>
    /// <returns>**true** to dismiss the access key display when an access key is invoked; otherwise, **false**.</returns>
    public extern bool ExitDisplayModeOnAccessKeyInvoked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates what decorations are applied to the text.</summary>
    /// <returns>A value of the enumeration. The default is **None**.</returns>
    public extern TextDecorations TextDecorations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether an element defines its own access key scope.</summary>
    /// <returns>**true** if an element defines its own scope; otherwise, **false**.</returns>
    public extern bool IsAccessKeyScope { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a source element that provides the access key scope for this element, even if it's not in the visual tree of the source element.</summary>
    /// <returns>The element that defines the access key scope.</returns>
    public extern DependencyObject AccessKeyScopeOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates where the KeyTip is placed in relation to the text element.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern KeyTipPlacementMode KeyTipPlacementMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far left or right the keytip is placed in relation to the text element.</summary>
    /// <returns>The number of pixels to move the KeyTip. Positive values move it right. Negative values move it left.</returns>
    public extern double KeyTipHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far up or down the keytip is placed in relation to the text element.</summary>
    /// <returns>The number of pixels to move the KeyTip. Positive values move it down. Negative values move it up.</returns>
    public extern double KeyTipVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the access key sequence is started to notify controls that they should show access key visuals.</summary>
    public extern event TypedEventHandler<TextElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    /// <summary>Occurs when the access key sequence is complete to notify controls that they should hide access key visuals.</summary>
    public extern event TypedEventHandler<TextElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    /// <summary>Occurs when a user completes an access key sequence to notify the element that the access key action should be invoked.</summary>
    public extern event TypedEventHandler<TextElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;

    /// <summary>Gets or sets the XamlRoot in which this element is being viewed.</summary>
    /// <returns>The XamlRoot in which this element is being viewed. The default is **null**.</returns>
    public extern XamlRoot XamlRoot { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void ITextElementOverrides.OnDisconnectVisualChildren();

    /// <summary>Identifies the **TextDecorations** dependency property.</summary>
    /// <returns>The identifier for the **TextDecorations** dependency property.</returns>
    public static extern DependencyProperty TextDecorationsProperty { [MethodImpl] get; }

    /// <summary>Identifies the **IsAccessKeyScope** dependency property.</summary>
    /// <returns>The identifier for the **IsAccessKeyScope** dependency property.</returns>
    public static extern DependencyProperty IsAccessKeyScopeProperty { [MethodImpl] get; }

    /// <summary>Identifies the **AccessKeyScopeOwner** dependency property.</summary>
    /// <returns>The identifier for the **AccessKeyScopeOwner** dependency property.</returns>
    public static extern DependencyProperty AccessKeyScopeOwnerProperty { [MethodImpl] get; }

    /// <summary>Identifies the **KeyTipPlacementMode** dependency property.</summary>
    /// <returns>The identifier for the **KeyTipPlacementMode** dependency property.</returns>
    public static extern DependencyProperty KeyTipPlacementModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the **KeyTipHorizontalOffset** dependency property.</summary>
    /// <returns>The identifier for the **KeyTipHorizontalOffset** dependency property.</returns>
    public static extern DependencyProperty KeyTipHorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the **KeyTipVerticalOffset** dependency property.</summary>
    /// <returns>The identifier for the **KeyTipVerticalOffset** dependency property.</returns>
    public static extern DependencyProperty KeyTipVerticalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the AllowFocusOnInteraction dependency property.</summary>
    /// <returns>The identifier for the AllowFocusOnInteraction dependency property.</returns>
    public static extern DependencyProperty AllowFocusOnInteractionProperty { [MethodImpl] get; }

    /// <summary>Identifies the AccessKey dependency property.</summary>
    /// <returns>The identifier for the AccessKey dependency property.</returns>
    public static extern DependencyProperty AccessKeyProperty { [MethodImpl] get; }

    /// <summary>Identifies the ExitDisplayModeOnAccessKeyInvoked dependency property.</summary>
    /// <returns>The identifier for the ExitDisplayModeOnAccessKeyInvoked dependency property.</returns>
    public static extern DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextScaleFactorEnabled  dependency property.</summary>
    /// <returns>The identifier for the IsTextScaleFactorEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontSize dependency property.</summary>
    /// <returns>Identifier for the FontSize dependency property.</returns>
    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontFamily dependency property.</summary>
    /// <returns>The identifier for the FontFamily dependency property.</returns>
    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontWeight dependency property.</summary>
    /// <returns>Identifier for the FontWeight dependency property.</returns>
    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontStyle dependency property.</summary>
    /// <returns>Identifier for the FontStyle dependency property.</returns>
    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontStretch dependency property.</summary>
    /// <returns>Identifier for the FontStretch dependency property.</returns>
    public static extern DependencyProperty FontStretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the CharacterSpacing dependency property.</summary>
    /// <returns>The identifier for the CharacterSpacing dependency property.</returns>
    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Foreground dependency property.</summary>
    /// <returns>Identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the Language dependency property.</summary>
    /// <returns>The identifier for the Language dependency property.</returns>
    public static extern DependencyProperty LanguageProperty { [MethodImpl] get; }
  }
}
