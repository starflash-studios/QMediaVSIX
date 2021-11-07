// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Paragraph
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Provides a block-level content element that is used to group content into a paragraph.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Inlines")]
  [Static(typeof (IParagraphStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Paragraph : Block, IParagraph
  {
    /// <summary>Initializes a new instance of the Paragraph class.</summary>
    [MethodImpl]
    public extern Paragraph();

    /// <summary>Gets an InlineCollection containing the top-level Inline elements that include the contents of the Paragraph.</summary>
    /// <returns>An InlineCollection containing the Inline elements that include the contents of the Paragraph.</returns>
    public extern InlineCollection Inlines { [MethodImpl] get; }

    /// <summary>Gets or sets the indentation of the first line of text in a paragraph, in pixels.</summary>
    /// <returns>The offset amount, in pixels, of the first line of text in a paragraph.</returns>
    public extern double TextIndent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the TextIndent dependency property.</summary>
    /// <returns>The identifier for the TextIndent dependency property.</returns>
    public static extern DependencyProperty TextIndentProperty { [MethodImpl] get; }
  }
}
