// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  /// <summary>Defines the style of the rendered text in a TimedTextCue. You can set the style of a substring within a TimedTextLine by using the Subformats property.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class TimedTextStyle : ITimedTextStyle, ITimedTextStyle2, ITimedTextStyle3
  {
    /// <summary>Initializes a new instance of the TimedTextStyle class.</summary>
    [MethodImpl]
    public extern TimedTextStyle();

    /// <summary>Gets or sets the name of the timed text style.</summary>
    /// <returns>The name of the timed text style.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font family of timed text.</summary>
    /// <returns>The font family of timed text.</returns>
    public extern string FontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font size of timed text.</summary>
    /// <returns>The font size of timed text.</returns>
    public extern TimedTextDouble FontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the weight of timed text.</summary>
    /// <returns>The weight of timed text.</returns>
    public extern TimedTextWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the timed text glyphs.</summary>
    /// <returns>The color of the timed text glyphs.</returns>
    public extern Color Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of timed text.</summary>
    /// <returns>The background color of timed text.</returns>
    public extern Color Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating if the background color stays visible when no text is being displayed.</summary>
    /// <returns>A value indicating if the background color stays visible when no text is being displayed.</returns>
    public extern bool IsBackgroundAlwaysShown { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the direction that timed text is flowed.</summary>
    /// <returns>A value indicating the direction that the timed text is flows.</returns>
    public extern TimedTextFlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the alignment of timed text lines.</summary>
    /// <returns>The alignment of timed text lines.</returns>
    public extern TimedTextLineAlignment LineAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the outline color of timed text.</summary>
    /// <returns>The outline color of timed text.</returns>
    public extern Color OutlineColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the outline of the timed text.</summary>
    /// <returns>The thickness of the outline of the timed text.</returns>
    public extern TimedTextDouble OutlineThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius of the blur applied to outline of the timed text.</summary>
    /// <returns>The radius of the blur applied to outline of the timed text.</returns>
    public extern TimedTextDouble OutlineRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the font style of timed text.</summary>
    /// <returns>A value that specifies the font style of timed text.</returns>
    public extern TimedTextFontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether underline text is enabled for the timed text.</summary>
    /// <returns>True if underline text is enabled; otherwise, false.</returns>
    public extern bool IsUnderlineEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether strikethrough text is enabled for the timed text.</summary>
    /// <returns>True if strikethrough text is enabled; otherwise, false.</returns>
    public extern bool IsLineThroughEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether overline text is enabled for the timed text.</summary>
    /// <returns>True if overline text is enabled; otherwise, false.</returns>
    public extern bool IsOverlineEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextRuby Ruby { [MethodImpl] get; }

    public extern TimedTextBouten Bouten { [MethodImpl] get; }

    public extern bool IsTextCombined { [MethodImpl] get; [MethodImpl] set; }

    public extern double FontAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }
  }
}
