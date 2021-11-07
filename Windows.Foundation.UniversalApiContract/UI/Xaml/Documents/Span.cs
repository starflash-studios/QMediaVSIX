// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Span
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Groups other Inline content elements. Parent class for Bold, Hyperlink, Italic and Underline.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Inlines")]
  [Composable(typeof (ISpanFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class Span : Inline, ISpan
  {
    /// <summary>Initializes a new instance of the Span class.</summary>
    [MethodImpl]
    public extern Span();

    /// <summary>Gets an InlineCollection containing the top-level inline elements that include the contents of Span.</summary>
    /// <returns>An InlineCollection containing the inline elements that include the contents of the Span. This property has no default value.</returns>
    public extern InlineCollection Inlines { [MethodImpl] get; [MethodImpl] set; }
  }
}
