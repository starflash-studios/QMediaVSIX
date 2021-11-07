// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.TextHighlighter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Represents an object that highlights one or more ranges of text.</summary>
  [Static(typeof (ITextHighlighterStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (ITextHighlighterFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class TextHighlighter : ITextHighlighter
  {
    /// <summary>Initializes a new instance of the TextHighlighter class.</summary>
    [MethodImpl]
    public extern TextHighlighter();

    /// <summary>Gets the text ranges to highlight.</summary>
    /// <returns>The collection of text ranges to highlight.</returns>
    public extern IVector<TextRange> Ranges { [MethodImpl] get; }

    /// <summary>Gets or sets the brush used to color highlighted text.</summary>
    /// <returns>The brush used to color highlighted text.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to highlight the text.</summary>
    /// <returns>The brush used to highlight the text.</returns>
    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Foreground dependency property.</summary>
    /// <returns>The identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the Background dependency property.</summary>
    /// <returns>The identifier for the Background dependency property.</returns>
    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }
  }
}
