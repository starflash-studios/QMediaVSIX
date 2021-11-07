// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.SelectableWordSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Represents a segment from your provided text that includes a word and any trailing whitespace and/or punctuation after this word.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SelectableWordSegment : ISelectableWordSegment
  {
    /// <summary>Gets the text of the selected word identified by this SelectableWordSegment object.</summary>
    /// <returns>The selected word.</returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Gets the TextSegment that identifies the source text's sub-string that is the selected word.</summary>
    /// <returns>The TextSegment structure that identifies the word in your provided text.</returns>
    public extern TextSegment SourceTextSegment { [MethodImpl] get; }
  }
}
