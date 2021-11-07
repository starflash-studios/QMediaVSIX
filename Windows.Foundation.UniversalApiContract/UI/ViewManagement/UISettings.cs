// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.UISettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Contains a set of common app user interface settings and operations.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UISettings : 
    IUISettings,
    IUISettings2,
    IUISettings3,
    IUISettings4,
    IUISettings5,
    IUISettings6
  {
    /// <summary>Creates a new default instance of the UISettings class.</summary>
    [MethodImpl]
    public extern UISettings();

    /// <summary>Gets the directional preference of the user interface created by the app view.</summary>
    /// <returns>The directional preference of the user interface.</returns>
    public extern HandPreference HandPreference { [MethodImpl] get; }

    /// <summary>Gets the size of a new cursor created by the app view.</summary>
    /// <returns>The size of a new cursor.</returns>
    public extern Size CursorSize { [MethodImpl] get; }

    /// <summary>Gets the size of a scroll bar for windows associated with the app view.</summary>
    /// <returns>The size of the scroll bar.</returns>
    public extern Size ScrollBarSize { [MethodImpl] get; }

    /// <summary>Gets the size of a scroll bar arrow for windows associated with the app view.</summary>
    /// <returns>The size of a scroll bar arrow.</returns>
    public extern Size ScrollBarArrowSize { [MethodImpl] get; }

    /// <summary>Gets the size of a thumb box for windows associated with the app view.</summary>
    /// <returns>The size of the thumb box.</returns>
    public extern Size ScrollBarThumbBoxSize { [MethodImpl] get; }

    /// <summary>Gets the length of time a message is displayed for the app view.</summary>
    /// <returns>The duration the message is displayed, in seconds.</returns>
    public extern uint MessageDuration { [MethodImpl] get; }

    /// <summary>Gets whether animations are enabled for the user interface.</summary>
    /// <returns>**true** if animations are enabled; **false** if not.</returns>
    public extern bool AnimationsEnabled { [MethodImpl] get; }

    /// <summary>Gets whether the caret can be used for browse operations.</summary>
    /// <returns>True if the caret can be used for browse operations; false if it cannot.</returns>
    public extern bool CaretBrowsingEnabled { [MethodImpl] get; }

    /// <summary>Gets the blink rate of a new caret created by the app view.</summary>
    /// <returns>The blink rate of the new caret, in milliseconds.</returns>
    public extern uint CaretBlinkRate { [MethodImpl] get; }

    /// <summary>Gets the width of a new caret created by the app view.</summary>
    /// <returns>The width of a new caret, in pixels.</returns>
    public extern uint CaretWidth { [MethodImpl] get; }

    /// <summary>Gets the maximum allowed time between clicks in a double-click operation.</summary>
    /// <returns>The delta of a double-click operation, in milliseconds.</returns>
    public extern uint DoubleClickTime { [MethodImpl] get; }

    /// <summary>Gets the amount of time the mouse pointer can rest in a hover rectangle before a hover event is raised.</summary>
    /// <returns>The hover time before a hover event is raised, in milliseconds.</returns>
    public extern uint MouseHoverTime { [MethodImpl] get; }

    /// <summary>Gets the color used for a specific user interface element type, such as a button face or window text.</summary>
    /// <param name="desiredElement">The type of element for which the color will be obtained.</param>
    /// <returns>The color of the element type, expressed as a 32-bit color value.</returns>
    [MethodImpl]
    public extern Color UIElementColor(UIElementType desiredElement);

    /// <summary>Gets the value of the system text size setting.</summary>
    /// <returns>The value ranges from 1 to 2.25.</returns>
    public extern double TextScaleFactor { [MethodImpl] get; }

    /// <summary>Occurs when the system text size setting is changed.</summary>
    public extern event TypedEventHandler<UISettings, object> TextScaleFactorChanged;

    /// <summary>Returns the color value of the specified color type.</summary>
    /// <param name="desiredColor">An enumeration value that specifies the type of color to get a value for.</param>
    /// <returns>The color value of the specified color type.</returns>
    [MethodImpl]
    public extern Color GetColorValue(UIColorType desiredColor);

    /// <summary>Occurs when color values have changed.</summary>
    public extern event TypedEventHandler<UISettings, object> ColorValuesChanged;

    /// <summary>Gets a value that indicates whether the system Transparency effects setting is enabled.</summary>
    /// <returns>**true** if Transparency UI effects are enabled; otherwise, **false**.</returns>
    public extern bool AdvancedEffectsEnabled { [MethodImpl] get; }

    /// <summary>Occurs when the system advanced UI effects setting is enabled or disabled.</summary>
    public extern event TypedEventHandler<UISettings, object> AdvancedEffectsEnabledChanged;

    /// <summary>Gets whether the user has specified that scroll bars should be automatically hidden when not being interacted with.</summary>
    /// <returns>True, if **Settings -&gt; Ease of Access -&gt; Display -&gt; Automatically hide scroll bars in Windows** is set. Otherwise, false.</returns>
    public extern bool AutoHideScrollBars { [MethodImpl] get; }

    /// <summary>Event invoked when the AutoHideScrollBars state changes.</summary>
    public extern event TypedEventHandler<UISettings, UISettingsAutoHideScrollBarsChangedEventArgs> AutoHideScrollBarsChanged;

    /// <summary>Occurs when the value of the AnimationsEnabled property has changed.</summary>
    public extern event TypedEventHandler<UISettings, UISettingsAnimationsEnabledChangedEventArgs> AnimationsEnabledChanged;

    /// <summary>Occurs when the value of the MessageDuration property has changed.</summary>
    public extern event TypedEventHandler<UISettings, UISettingsMessageDurationChangedEventArgs> MessageDurationChanged;
  }
}
