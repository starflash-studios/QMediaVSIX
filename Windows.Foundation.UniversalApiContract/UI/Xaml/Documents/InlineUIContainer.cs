// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.InlineUIContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Provides an inline content element that enables UIElement types to be embedded in the content of a RichTextBlock.</summary>
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Child")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InlineUIContainer : Inline, IInlineUIContainer
  {
    /// <summary>Initializes a new instance of the InlineUIContainer class.</summary>
    [MethodImpl]
    public extern InlineUIContainer();

    /// <summary>Gets or sets the UIElement hosted by the InlineUIContainer.</summary>
    /// <returns>The UIElement hosted by the InlineUIContainer.</returns>
    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }
  }
}
