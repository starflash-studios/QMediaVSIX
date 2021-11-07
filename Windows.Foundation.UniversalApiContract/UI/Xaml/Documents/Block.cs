// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Block
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>An abstract class that provides a base for all block-level content elements.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBlockStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IBlockFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBlockStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class Block : TextElement, IBlock, IBlock2
  {
    /// <summary>Provides base class initialization behavior for Block derived classes.</summary>
    [MethodImpl]
    protected extern Block();

    /// <summary>Gets or sets the horizontal alignment of the text content.</summary>
    /// <returns>The horizontal alignment of the text content. The default is **Left**.</returns>
    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height of each line of content.</summary>
    /// <returns>The pixel height of each line as modified by LineStackingStrategy. A value of 0 indicates that the line height is determined automatically from the current font characteristics. The default is 0.</returns>
    public extern double LineHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how a line box is determined for each line of text in the Block.</summary>
    /// <returns>A value that indicates how a line box is determined for each line of text in the Block. The default is **MaxHeight**.</returns>
    public extern LineStackingStrategy LineStackingStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount of space around a Block element.</summary>
    /// <returns>The amount of space around a Block element.</returns>
    public extern Thickness Margin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how text is aligned in the Block.</summary>
    /// <returns>One of the TextAlignment enumeration values that specifies how text is aligned. The default is **Left**.</returns>
    public extern TextAlignment HorizontalTextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the HorizontalTextAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalTextAlignment dependency property.</returns>
    public static extern DependencyProperty HorizontalTextAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextAlignment dependency property.</summary>
    /// <returns>The identifier for the TextAlignment dependency property.</returns>
    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineHeight dependency property.</summary>
    /// <returns>The identifier for the LineHeight dependency property.</returns>
    public static extern DependencyProperty LineHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineStackingStrategy dependency property.</summary>
    /// <returns>The identifier for the LineStackingStrategy dependency property.</returns>
    public static extern DependencyProperty LineStackingStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the Margin dependency property.</summary>
    /// <returns>The identifier for the Margin dependency property.</returns>
    public static extern DependencyProperty MarginProperty { [MethodImpl] get; }
  }
}
