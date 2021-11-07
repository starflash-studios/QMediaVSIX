// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TextWrapping
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Specifies whether text wraps when it reaches the edge of its container.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum TextWrapping
  {
    /// <summary>No line wrapping is performed.</summary>
    NoWrap = 1,
    /// <summary>Line breaking occurs if a line of text overflows beyond the available width of its container. Line breaking occurs even if the text logic can't determine any line break opportunity. For example, if a very long word is constrained in a fixed-width container that can't scroll, it will wrap at a point that might be in the middle of a word.</summary>
    Wrap = 2,
    /// <summary>Line-breaking occurs if the line overflows beyond the available block width. A line may overflow beyond the block width if the text logic can't determine a line break opportunity. For example, if a very long word is constrained in a fixed-width container that can't scroll, it will overflow the long word and continue the text after the long word on the next line. Not supported by all controls; see Remarks.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WrapWholeWords = 3,
  }
}
