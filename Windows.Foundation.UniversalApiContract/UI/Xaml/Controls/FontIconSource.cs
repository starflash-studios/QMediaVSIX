// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.FontIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an icon source that uses a glyph from the specified font.</summary>
  [WebHostHidden]
  [Static(typeof (IFontIconSourceStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IFontIconSourceFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  public class FontIconSource : IconSource, IFontIconSource
  {
    /// <summary>Initializes a new instance of the FontIconSource class.</summary>
    [MethodImpl]
    public extern FontIconSource();

    /// <summary>Gets or sets the character code that identifies the icon glyph.</summary>
    /// <returns>The hexadecimal character code for the icon glyph.</returns>
    public extern string Glyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the size of the icon glyph.</summary>
    /// <returns>A non-negative value that specifies the font size, measured in pixels.</returns>
    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font used to display the icon glyph.</summary>
    /// <returns>The font used to display the icon glyph.</returns>
    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the icon glyph.</summary>
    /// <returns>A value that specifies the thickness of the icon glyph. The default is **Normal**.</returns>
    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style for the icon glyph.</summary>
    /// <returns>A named constant of the enumeration that specifies the style in which the icon glyph is rendered. The default is **Normal**.</returns>
    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether automatic text enlargement, to reflect the system text size setting, is enabled.</summary>
    /// <returns>**true** if automatic text enlargement is enabled; otherwise, **false**.</returns>
    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the icon is mirrored when its containing element's FlowDirection is **RightToLeft**.</summary>
    /// <returns>**true** if the icon is mirrored when the FlowDirection is FlowDirection.RightToLeft; otherwise, **false**. The default is **false**.</returns>
    public extern bool MirroredWhenRightToLeft { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifier for the Glyph dependency property.</summary>
    /// <returns>The identifier for the Glyph dependency property.</returns>
    public static extern DependencyProperty GlyphProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the FontSize dependency property.</summary>
    /// <returns>The identifier for the FontSize dependency property.</returns>
    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the FontFamily dependency property.</summary>
    /// <returns>The identifier for the FontFamily dependency property.</returns>
    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the FontWeight dependency property.</summary>
    /// <returns>The identifier for the FontWeight dependency property.</returns>
    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the FontStyle dependency property.</summary>
    /// <returns>The identifier for the FontStyle dependency property.</returns>
    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the IsTextScaleFactorEnabled dependency property.</summary>
    /// <returns>The identifier for the IsTextScaleFactorEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MirroredWhenRightToLeft dependency property.</summary>
    /// <returns>The identifier for the MirroredWhenRightToLeft dependency property.</returns>
    public static extern DependencyProperty MirroredWhenRightToLeftProperty { [MethodImpl] get; }
  }
}
